using System;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/UIBetterGrid")]
public class UIBetterGrid : MonoBehaviour
{
	public int itemSize = 100;

	public bool cullContent = true;

	private Transform mTrans;

	private UIPanel mPanel;

	private UIScrollView mScroll;

	private bool mHorizontal;

	private BetterList<Transform> mChildren = new BetterList<Transform>();

	protected virtual void Start()
	{
		this.SortBasedOnScrollMovement();
		this.WrapContent();
		if (this.mScroll != null)
		{
			this.mScroll.GetComponent<UIPanel>().onClipMove = new UIPanel.OnClippingMoved(this.OnMove);
			this.mScroll.restrictWithinPanel = true;
		}
	}

	protected virtual void OnMove(UIPanel panel)
	{
		this.WrapContent();
	}

	[ContextMenu("Sort Based on Scroll Movement")]
	public void SortBasedOnScrollMovement()
	{
		if (!this.CacheScrollView())
		{
			return;
		}
		this.mChildren.Clear();
		for (int i = 0; i < this.mTrans.childCount; i++)
		{
			this.mChildren.Add(this.mTrans.GetChild(i));
		}
		if (this.mHorizontal)
		{
			this.mChildren.Sort(new BetterList<Transform>.CompareFunc(UIGrid.SortHorizontal));
		}
		else
		{
			this.mChildren.Sort(new BetterList<Transform>.CompareFunc(UIGrid.SortVertical));
		}
	}

	[ContextMenu("Sort Alphabetically")]
	public void SortAlphabetically()
	{
		if (!this.CacheScrollView())
		{
			return;
		}
		this.mChildren.Clear();
		for (int i = 0; i < this.mTrans.childCount; i++)
		{
			this.mChildren.Add(this.mTrans.GetChild(i));
		}
		this.mChildren.Sort(new BetterList<Transform>.CompareFunc(UIGrid.SortByName));
	}

	protected bool CacheScrollView()
	{
		this.mTrans = base.transform;
		this.mPanel = NGUITools.FindInParents<UIPanel>(base.gameObject);
		this.mScroll = this.mPanel.GetComponent<UIScrollView>();
		if (this.mScroll == null)
		{
			return false;
		}
		if (this.mScroll.movement == UIScrollView.Movement.Horizontal)
		{
			this.mHorizontal = true;
		}
		else
		{
			if (this.mScroll.movement != UIScrollView.Movement.Vertical)
			{
				return false;
			}
			this.mHorizontal = false;
		}
		return true;
	}

	private void ResetChildPositions()
	{
		for (int i = 0; i < this.mChildren.size; i++)
		{
			Transform transform = this.mChildren[i];
			transform.localPosition = ((!this.mHorizontal) ? new Vector3(0f, (float)(-(float)i * this.itemSize), 0f) : new Vector3((float)(i * this.itemSize), 0f, 0f));
		}
	}

	public void WrapContent()
	{
		Vector3[] worldCorners = this.mPanel.worldCorners;
		for (int i = 0; i < 4; i++)
		{
			Vector3 vector = worldCorners[i];
			vector = this.mTrans.InverseTransformPoint(vector);
			worldCorners[i] = vector;
		}
		Vector3 vector2 = Vector3.Lerp(worldCorners[0], worldCorners[2], 0.5f);
		if (this.mHorizontal)
		{
			float num = worldCorners[0].x - (float)this.itemSize;
			float num2 = worldCorners[2].x + (float)this.itemSize;
			for (int j = 0; j < this.mChildren.size; j++)
			{
				Transform transform = this.mChildren[j];
				float num3 = transform.localPosition.x - vector2.x;
				if (this.cullContent)
				{
					num3 += this.mPanel.clipOffset.x - this.mTrans.localPosition.x;
					if (!UICamera.IsPressed(transform.gameObject))
					{
						NGUITools.SetActive(transform.gameObject, num3 > num && num3 < num2, false);
					}
				}
			}
		}
		else
		{
			float num4 = worldCorners[0].y - (float)this.itemSize;
			float num5 = worldCorners[2].y + (float)this.itemSize;
			for (int k = 0; k < this.mChildren.size; k++)
			{
				Transform transform2 = this.mChildren[k];
				float num6 = transform2.localPosition.y - vector2.y;
				if (this.cullContent)
				{
					num6 += this.mPanel.clipOffset.y - this.mTrans.localPosition.y;
					if (!UICamera.IsPressed(transform2.gameObject))
					{
						NGUITools.SetActive(transform2.gameObject, num6 > num4 && num6 < num5, false);
					}
				}
			}
		}
	}

	protected virtual void UpdateItem(Transform item, int index)
	{
	}
}
