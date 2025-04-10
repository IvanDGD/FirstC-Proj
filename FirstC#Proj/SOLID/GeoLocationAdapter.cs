using FirstC_Proj.SOLID.IInterface;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj.SOLID
{
    internal class GeoLocationAdapter : ICoordinatesService
    {
        private GeoLocation geoLocation;

        public GeoLocationAdapter(GeoLocation geoLocation)
        {
            this.geoLocation = geoLocation;
        }

        public(double Latitude, double Longitude) GetCoordinates()
        {
            string location = geoLocation.GetLocation();
            string[] parts = location.Split(',');

            if (parts.Length != 2)
            {
                return (0, 0);
            }
            string latString = parts[0].Replace('.', ',');
            string lonString = parts[1].Replace('.', ',');

            double latitude;
            double longitude;

            if (!double.TryParse(latString, out latitude) || !double.TryParse(lonString, out longitude))
            {
                return (0, 0);
            }

            return (latitude, longitude);
        }
    }
}
