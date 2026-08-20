using System.Collections.Generic;
using System.Numerics;

using ClashofClans.Files;
using ClashofClans.Files.Logic;
using ClashofClans.Logic;
using ClashofClans.Logic.Home;
using ClashofClans.Logic.Manager.Items.GameObjects;
using ClashofClans.Utilities.Netty;

namespace ClashofClans.Protocol.Commands.Client
{
	public class LogicBuyTrapCommand : LogicCommand
	{

		private int _buildingData;
		private int _x;
		private int _y;

		public LogicBuyTrapCommand(Device device, ByteBuffer buffer) : base(device, buffer)
		{
		}

		public override void Decode()
		{
			_x = Reader.ReadInt();
			_y = Reader.ReadInt();

			_buildingData = Reader.ReadInt();

			base.Decode();
		}

		public override void Execute()
		{
			Home home = Device.Player.Home;
			List<Trap> traps = home.GameObjectManager.GetTraps();

			LogicTrapData data = Csv.Tables.Get(LogicDataType.TRAP).GetDataWithId<LogicTrapData>(_buildingData);
			int cost = data.BuildCost[0];

			Trap trap = new Trap(home)
			{
				Position = new Vector2(_x, _y),
				Data = _buildingData,
				Id = 500000000 + traps.Count
			};

			if (home.UseResourceByName(trap.GetTrapData().BuildResource, cost))
			{
				trap.SetUpgradeLevel(-1);
				trap.StartUpgrade();

				traps.Add(trap);
			}
			else
			{
				Device.Disconnect("Failed to buy building.");
			}
		}
	}
}