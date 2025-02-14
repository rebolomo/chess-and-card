using ProtoBuf;
using System;

namespace MobaProtocol.Data
{
	[ProtoContract]
	public class LuckyMoneyAwardInfo
	{
		[ProtoMember(1)]
		public string shopId
		{
			get;
			set;
		}

		[ProtoMember(2)]
		public string itemTypeId
		{
			get;
			set;
		}
	}
}
