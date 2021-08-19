using Assets.Scripts.MVC.Locations;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts.MVC.Data
{
    [CreateAssetMenu(fileName = "LocationSettings", menuName = "Data/Unit/LocationSettings")]
    public class LocationData : ScriptableObject
    {
        [Serializable]
        private struct LocationInfo
        {
            public Location LocationPrefab;
            public Vector3Int _position;
        }
        [SerializeField] private List<LocationInfo> _locationInfo;
        public Location GetLocation()
        {
            var locationInfo = _locationInfo.First();
            return locationInfo.LocationPrefab;
        }
        public Vector3 GetLocationPosition()
        {
            var locationInfo = _locationInfo.First();
            return locationInfo._position;
        }
    }
}
