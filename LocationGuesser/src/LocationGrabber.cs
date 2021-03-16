using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMyLocations.src
{
	class LocationGrabber
	{
		private List<Location> locations;

		public LocationGrabber()
		{
		}

		public List<Location> getAllLocations()
		{
			string json = System.IO.File.ReadAllText("./../../resource/locations.json");
			this.locations = JsonConvert.DeserializeObject<List<Location>>(json);
			return new List<Location>(locations);	//dont know why, we'll see
		}
	}
}
