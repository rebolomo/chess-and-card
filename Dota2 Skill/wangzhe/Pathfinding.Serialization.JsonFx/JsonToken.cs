using System;

namespace Pathfinding.Serialization.JsonFx
{
	internal enum JsonToken
	{
		End,
		Undefined,
		Null,
		False,
		True,
		NaN,
		PositiveInfinity,
		NegativeInfinity,
		Number,
		String,
		ArrayStart,
		ArrayEnd,
		ObjectStart,
		ObjectEnd,
		NameDelim,
		ValueDelim,
		UnquotedName
	}
}
