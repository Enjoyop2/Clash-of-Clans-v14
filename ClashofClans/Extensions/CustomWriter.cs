using ClashofClans.Files.Logic;
using ClashofClans.Utilities.Netty;

namespace ClashofClans.Extensions
{
	public static class CustomWriter
	{
		public static void WriteData(this ByteBuffer buffer, LogicData value)
		{
			buffer.WriteInt(value.GetDataType());
			buffer.WriteInt(value.GetInstanceId());
		}
	}
}