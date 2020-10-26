using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusWithGarmoshka
{
	class StationCollection
	{
		readonly Dictionary<string, Station<Vehicle>> stationStages;

		public List<string> Keys => stationStages.Keys.ToList();

		private readonly int pictureWidth;

		private readonly int pictureHeight;

		public StationCollection(int pictureWidth, int pictureHeight)
		{
			stationStages = new Dictionary<string, Station<Vehicle>>();
			this.pictureWidth = pictureWidth;
			this.pictureHeight = pictureHeight;
		}

		public void AddStation(string name)
		{
			if (stationStages.Keys.Contains(name)) { return; }

			stationStages.Add(name, new Station<Vehicle>(pictureWidth, pictureHeight));
		}

		public void DelStation(string name)
		{
			if (stationStages.ContainsKey(name))
			{
				stationStages.Remove(name);
			}
		}

		public Station<Vehicle> this[string ind]
		{

			get
			{
				if (!stationStages.ContainsKey(ind))
				{
					return null;
				}
				return stationStages[ind];
			}

		}
	}
}
