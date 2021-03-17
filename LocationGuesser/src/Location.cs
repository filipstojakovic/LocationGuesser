using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMyLocations.src
{
	class Location
	{
		public string lat { get; set; }
		public string lng { get; set; }
		public string formatted_address { get; set; }

		public static List<Location> getAllLocations()
		{
			string json = System.IO.File.ReadAllText("./../../locations/locations.json");
			return JsonConvert.DeserializeObject<List<Location>>(json);
		}

		public override bool Equals(object obj)
		{
			return obj is Location location &&
				   lat == location.lat &&
				   lng == location.lng;
		}

		public override int GetHashCode()
		{
			int hashCode = 2124363670;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(lat);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(lng);
			return hashCode;
		}
	}
}
