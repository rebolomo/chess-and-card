using Pathfinding.Serialization;
using Pathfinding.Util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using UnityEngine;

namespace Pathfinding
{
	[Serializable]
	public class AstarData
	{
		[NonSerialized]
		public GridGraph gridGraph;

		[NonSerialized]
		public PointGraph pointGraph;

		public Type[] graphTypes;

		[NonSerialized]
		public NavGraph[] graphs = new NavGraph[0];

		[NonSerialized]
		public UserConnection[] userConnections = new UserConnection[0];

		public bool hasBeenReverted;

		[SerializeField]
		private byte[] data;

		[SerializeField]
		public float[] heightMap;

		public uint dataChecksum;

		public byte[] data_backup;

		[SerializeField]
		public TextAsset file_cachedStartup;

		public byte[] data_cachedStartup;

		[SerializeField]
		public bool cacheStartup;

		[SerializeField]
		public float gridNodeSize;

		[SerializeField]
		public int gridWidth;

		[SerializeField]
		public int gridDepth;

		[SerializeField]
		public Vector3 gridCenter;

		public AstarPath active
		{
			get
			{
				return AstarPath.active;
			}
		}

		public byte[] GetData()
		{
			return this.data;
		}

		public void SetData(byte[] data, uint checksum)
		{
			this.data = data;
			this.dataChecksum = checksum;
		}

		public void Awake()
		{
			this.userConnections = new UserConnection[0];
			this.graphs = new NavGraph[0];
			if (this.cacheStartup && this.file_cachedStartup != null)
			{
				this.LoadFromCache();
			}
			else
			{
				this.DeserializeGraphs();
			}
		}

		public void UpdateShortcuts()
		{
			this.gridGraph = (GridGraph)this.FindGraphOfType(typeof(GridGraph));
			this.pointGraph = (PointGraph)this.FindGraphOfType(typeof(PointGraph));
		}

		public void LoadFromCache()
		{
			AstarPath.active.BlockUntilPathQueueBlocked();
			if (this.file_cachedStartup != null)
			{
				byte[] bytes = this.file_cachedStartup.bytes;
				this.DeserializeGraphs(bytes);
				GraphModifier.TriggerEvent(GraphModifier.EventType.PostCacheLoad);
			}
			else
			{
				UnityEngine.Debug.LogError("Can't load from cache since the cache is empty");
			}
		}

		public byte[] SerializeGraphs()
		{
			return this.SerializeGraphs(SerializeSettings.Settings);
		}

		public byte[] SerializeGraphs(SerializeSettings settings)
		{
			uint num;
			return this.SerializeGraphs(settings, out num);
		}

		public byte[] SerializeGraphs(SerializeSettings settings, out uint checksum)
		{
			AstarPath.active.BlockUntilPathQueueBlocked();
			AstarSerializer astarSerializer = new AstarSerializer(this, settings);
			astarSerializer.OpenSerialize();
			this.SerializeGraphsPart(astarSerializer);
			byte[] result = astarSerializer.CloseSerialize();
			checksum = astarSerializer.GetChecksum();
			return result;
		}

		public void SerializeGraphsPart(AstarSerializer sr)
		{
			sr.SerializeGraphs(this.graphs);
			sr.SerializeUserConnections(this.userConnections);
			sr.SerializeNodes();
			sr.SerializeExtraInfo();
		}

		public void DeserializeGraphs()
		{
			if (this.data != null)
			{
				this.DeserializeGraphs(this.data);
			}
		}

		private void ClearGraphs()
		{
			if (this.graphs == null)
			{
				return;
			}
			for (int i = 0; i < this.graphs.Length; i++)
			{
				if (this.graphs[i] != null)
				{
					this.graphs[i].OnDestroy();
				}
			}
			this.graphs = null;
			this.UpdateShortcuts();
		}

		public void OnDestroy()
		{
			this.ClearGraphs();
		}

		public void DeserializeGraphs(byte[] bytes)
		{
			AstarPath.active.BlockUntilPathQueueBlocked();
			try
			{
				if (bytes == null)
				{
					throw new ArgumentNullException("Bytes should not be null when passed to DeserializeGraphs");
				}
				AstarSerializer astarSerializer = new AstarSerializer(this);
				if (astarSerializer.OpenDeserialize(bytes))
				{
					this.DeserializeGraphsPart(astarSerializer);
					astarSerializer.CloseDeserialize();
					this.UpdateShortcuts();
				}
				else
				{
					UnityEngine.Debug.Log("Invalid data file (cannot read zip).\nThe data is either corrupt or it was saved using a 3.0.x or earlier version of the system");
				}
				this.active.VerifyIntegrity();
			}
			catch (Exception arg)
			{
				UnityEngine.Debug.LogWarning("Caught exception while deserializing data.\n" + arg);
				this.data_backup = bytes;
			}
		}

		public void DeserializeGraphsAdditive(byte[] bytes)
		{
			AstarPath.active.BlockUntilPathQueueBlocked();
			try
			{
				if (bytes == null)
				{
					throw new ArgumentNullException("Bytes should not be null when passed to DeserializeGraphs");
				}
				AstarSerializer astarSerializer = new AstarSerializer(this);
				if (astarSerializer.OpenDeserialize(bytes))
				{
					this.DeserializeGraphsPartAdditive(astarSerializer);
					astarSerializer.CloseDeserialize();
				}
				else
				{
					UnityEngine.Debug.Log("Invalid data file (cannot read zip).");
				}
				this.active.VerifyIntegrity();
			}
			catch (Exception arg)
			{
				UnityEngine.Debug.LogWarning("Caught exception while deserializing data.\n" + arg);
			}
		}

		public void DeserializeGraphsPart(AstarSerializer sr)
		{
			this.ClearGraphs();
			this.graphs = sr.DeserializeGraphs();
			if (this.graphs != null)
			{
				for (int j = 0; j < this.graphs.Length; j++)
				{
					if (this.graphs[j] != null)
					{
						this.graphs[j].graphIndex = (uint)j;
					}
				}
			}
			this.userConnections = sr.DeserializeUserConnections();
			sr.DeserializeExtraInfo();
			int i;
			for (i = 0; i < this.graphs.Length; i++)
			{
				if (this.graphs[i] != null)
				{
					this.graphs[i].GetNodes(delegate(GraphNode node)
					{
						node.GraphIndex = (uint)i;
						return true;
					});
				}
			}
			sr.PostDeserialization();
		}

		public void DeserializeGraphsPartAdditive(AstarSerializer sr)
		{
			if (this.graphs == null)
			{
				this.graphs = new NavGraph[0];
			}
			if (this.userConnections == null)
			{
				this.userConnections = new UserConnection[0];
			}
			List<NavGraph> list = new List<NavGraph>(this.graphs);
			list.AddRange(sr.DeserializeGraphs());
			this.graphs = list.ToArray();
			if (this.graphs != null)
			{
				for (int l = 0; l < this.graphs.Length; l++)
				{
					if (this.graphs[l] != null)
					{
						this.graphs[l].graphIndex = (uint)l;
					}
				}
			}
			List<UserConnection> list2 = new List<UserConnection>(this.userConnections);
			list2.AddRange(sr.DeserializeUserConnections());
			this.userConnections = list2.ToArray();
			sr.DeserializeNodes();
			int i;
			for (i = 0; i < this.graphs.Length; i++)
			{
				if (this.graphs[i] != null)
				{
					this.graphs[i].GetNodes(delegate(GraphNode node)
					{
						node.GraphIndex = (uint)i;
						return true;
					});
				}
			}
			sr.DeserializeExtraInfo();
			sr.PostDeserialization();
			for (int j = 0; j < this.graphs.Length; j++)
			{
				for (int k = j + 1; k < this.graphs.Length; k++)
				{
					if (this.graphs[j] != null && this.graphs[k] != null && this.graphs[j].guid == this.graphs[k].guid)
					{
						UnityEngine.Debug.LogWarning("Guid Conflict when importing graphs additively. Imported graph will get a new Guid.\nThis message is (relatively) harmless.");
						this.graphs[j].guid = Pathfinding.Util.Guid.NewGuid();
						break;
					}
				}
			}
		}

		public void FindGraphTypes()
		{
			Assembly assembly = Assembly.GetAssembly(typeof(AstarPath));
			Type[] types = assembly.GetTypes();
			List<Type> list = new List<Type>();
			Type[] array = types;
			for (int i = 0; i < array.Length; i++)
			{
				Type type = array[i];
				for (Type baseType = type.BaseType; baseType != null; baseType = baseType.BaseType)
				{
					if (object.Equals(baseType, typeof(NavGraph)))
					{
						list.Add(type);
						break;
					}
				}
			}
			this.graphTypes = list.ToArray();
		}

		public Type GetGraphType(string type)
		{
			for (int i = 0; i < this.graphTypes.Length; i++)
			{
				if (this.graphTypes[i].Name == type)
				{
					return this.graphTypes[i];
				}
			}
			return null;
		}

		public NavGraph CreateGraph(string type)
		{
			UnityEngine.Debug.Log("Creating Graph of type '" + type + "'");
			for (int i = 0; i < this.graphTypes.Length; i++)
			{
				if (this.graphTypes[i].Name == type)
				{
					return this.CreateGraph(this.graphTypes[i]);
				}
			}
			UnityEngine.Debug.LogError("Graph type (" + type + ") wasn't found");
			return null;
		}

		public NavGraph CreateGraph(Type type)
		{
			NavGraph navGraph = Activator.CreateInstance(type) as NavGraph;
			navGraph.active = this.active;
			return navGraph;
		}

		public NavGraph AddGraph(string type)
		{
			NavGraph navGraph = null;
			for (int i = 0; i < this.graphTypes.Length; i++)
			{
				if (this.graphTypes[i].Name == type)
				{
					navGraph = this.CreateGraph(this.graphTypes[i]);
				}
			}
			if (navGraph == null)
			{
				UnityEngine.Debug.LogError("No NavGraph of type '" + type + "' could be found");
				return null;
			}
			this.AddGraph(navGraph);
			return navGraph;
		}

		public NavGraph AddGraph(Type type)
		{
			NavGraph navGraph = null;
			for (int i = 0; i < this.graphTypes.Length; i++)
			{
				if (object.Equals(this.graphTypes[i], type))
				{
					navGraph = this.CreateGraph(this.graphTypes[i]);
				}
			}
			if (navGraph == null)
			{
				UnityEngine.Debug.LogError(string.Concat(new object[]
				{
					"No NavGraph of type '",
					type,
					"' could be found, ",
					this.graphTypes.Length,
					" graph types are avaliable"
				}));
				return null;
			}
			this.AddGraph(navGraph);
			return navGraph;
		}

		public void AddGraph(NavGraph graph)
		{
			AstarPath.active.BlockUntilPathQueueBlocked();
			for (int i = 0; i < this.graphs.Length; i++)
			{
				if (this.graphs[i] == null)
				{
					this.graphs[i] = graph;
					graph.active = this.active;
					graph.Awake();
					graph.graphIndex = (uint)i;
					this.UpdateShortcuts();
					return;
				}
			}
			if (this.graphs != null && (long)this.graphs.Length >= 255L)
			{
				throw new Exception("Graph Count Limit Reached. You cannot have more than " + 255u + " graphs. Some compiler directives can change this limit, e.g ASTAR_MORE_AREAS, look under the 'Optimizations' tab in the A* Inspector");
			}
			this.graphs = new List<NavGraph>(this.graphs)
			{
				graph
			}.ToArray();
			this.UpdateShortcuts();
			graph.active = this.active;
			graph.Awake();
			graph.graphIndex = (uint)(this.graphs.Length - 1);
		}

		public bool RemoveGraph(NavGraph graph)
		{
			graph.SafeOnDestroy();
			int i;
			for (i = 0; i < this.graphs.Length; i++)
			{
				if (this.graphs[i] == graph)
				{
					break;
				}
			}
			if (i == this.graphs.Length)
			{
				return false;
			}
			this.graphs[i] = null;
			this.UpdateShortcuts();
			return true;
		}

		public static NavGraph GetGraph(GraphNode node)
		{
			if (node == null)
			{
				return null;
			}
			AstarPath active = AstarPath.active;
			if (active == null)
			{
				return null;
			}
			AstarData astarData = active.astarData;
			if (astarData == null)
			{
				return null;
			}
			if (astarData.graphs == null)
			{
				return null;
			}
			uint graphIndex = node.GraphIndex;
			if ((ulong)graphIndex >= (ulong)((long)astarData.graphs.Length))
			{
				return null;
			}
			return astarData.graphs[(int)graphIndex];
		}

		public GraphNode GetNode(int graphIndex, int nodeIndex)
		{
			return this.GetNode(graphIndex, nodeIndex, this.graphs);
		}

		public GraphNode GetNode(int graphIndex, int nodeIndex, NavGraph[] graphs)
		{
			throw new NotImplementedException();
		}

		public NavGraph FindGraphOfType(Type type)
		{
			if (this.graphs != null)
			{
				for (int i = 0; i < this.graphs.Length; i++)
				{
					if (this.graphs[i] != null && object.Equals(this.graphs[i].GetType(), type))
					{
						return this.graphs[i];
					}
				}
			}
			return null;
		}

		[DebuggerHidden]
		public IEnumerable FindGraphsOfType(Type type)
		{
			AstarData.<FindGraphsOfType>c__Iterator0 <FindGraphsOfType>c__Iterator = new AstarData.<FindGraphsOfType>c__Iterator0();
			<FindGraphsOfType>c__Iterator.type = type;
			<FindGraphsOfType>c__Iterator.<$>type = type;
			<FindGraphsOfType>c__Iterator.<>f__this = this;
			AstarData.<FindGraphsOfType>c__Iterator0 expr_1C = <FindGraphsOfType>c__Iterator;
			expr_1C.$PC = -2;
			return expr_1C;
		}

		[DebuggerHidden]
		public IEnumerable GetUpdateableGraphs()
		{
			AstarData.<GetUpdateableGraphs>c__Iterator1 <GetUpdateableGraphs>c__Iterator = new AstarData.<GetUpdateableGraphs>c__Iterator1();
			<GetUpdateableGraphs>c__Iterator.<>f__this = this;
			AstarData.<GetUpdateableGraphs>c__Iterator1 expr_0E = <GetUpdateableGraphs>c__Iterator;
			expr_0E.$PC = -2;
			return expr_0E;
		}

		[DebuggerHidden]
		public IEnumerable GetRaycastableGraphs()
		{
			AstarData.<GetRaycastableGraphs>c__Iterator2 <GetRaycastableGraphs>c__Iterator = new AstarData.<GetRaycastableGraphs>c__Iterator2();
			<GetRaycastableGraphs>c__Iterator.<>f__this = this;
			AstarData.<GetRaycastableGraphs>c__Iterator2 expr_0E = <GetRaycastableGraphs>c__Iterator;
			expr_0E.$PC = -2;
			return expr_0E;
		}

		public int GetGraphIndex(NavGraph graph)
		{
			if (graph == null)
			{
				throw new ArgumentNullException("graph");
			}
			if (this.graphs != null)
			{
				for (int i = 0; i < this.graphs.Length; i++)
				{
					if (graph == this.graphs[i])
					{
						return i;
					}
				}
			}
			UnityEngine.Debug.LogError("Graph doesn't exist");
			return -1;
		}

		public int GuidToIndex(Pathfinding.Util.Guid guid)
		{
			if (this.graphs == null)
			{
				return -1;
			}
			for (int i = 0; i < this.graphs.Length; i++)
			{
				if (this.graphs[i] != null)
				{
					if (this.graphs[i].guid == guid)
					{
						return i;
					}
				}
			}
			return -1;
		}

		public NavGraph GuidToGraph(Pathfinding.Util.Guid guid)
		{
			if (this.graphs == null)
			{
				return null;
			}
			for (int i = 0; i < this.graphs.Length; i++)
			{
				if (this.graphs[i] != null)
				{
					if (this.graphs[i].guid == guid)
					{
						return this.graphs[i];
					}
				}
			}
			return null;
		}
	}
}
