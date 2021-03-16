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

		public override bool Equals(object obj)
		{
			return obj is Location location &&
				   lat == location.lat &&
				   lng == location.lng;
		}

		
	}
}
