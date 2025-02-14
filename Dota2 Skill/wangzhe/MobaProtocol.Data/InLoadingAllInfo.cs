using ProtoBuf;
using System;

namespace MobaProtocol.Data
{
	[ProtoContract]
	public class InLoadingAllInfo
	{
		[ProtoMember(1)]
		public byte[] InBattleRoomInfoBytes
		{
			get;
			set;
		}

		[ProtoMember(2)]
		public PvpStartGameInfo loginInfo
		{
			get;
			set;
		}
	}
}
