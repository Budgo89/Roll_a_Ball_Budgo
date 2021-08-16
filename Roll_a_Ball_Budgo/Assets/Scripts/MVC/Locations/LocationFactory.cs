using Assets.Scripts.MVC.Data;
using UnityEngine;

namespace Assets.Scripts.MVC.Locations
{
    class LocationFactory : ILocationFactory
    {
        private readonly LocationData _locationData;

        public LocationFactory(LocationData locationData)
        {
            _locationData = locationData;
        }

        public ILocation CreateLocation()
        {
            var location = _locationData.GetLocation();
            var locationPosition = _locationData.GetLocationPosition();
            return Object.Instantiate(location, locationPosition, Quaternion.identity);
        }
    }
}

