using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts.MVC.Data
{
    [CreateAssetMenu(fileName = "ZoneOutSettings", menuName = "Data/Unit/ZoneOutSettings")]
    public class ZoneOutData : ScriptableObject
    {
        [Serializable]
        private struct ZoneOutInfo
        {
            public ZoneOut zoneOutPrefab;
            public Vector3Int _position;
        }
        [SerializeField] private List<ZoneOutInfo> _zoneOutInfo;
        public ZoneOut GetZoneOut()
        {
            var zoneOutInfo = _zoneOutInfo.First();
            return zoneOutInfo.zoneOutPrefab;
        }
        public Vector3 GetZoneOutPosition()
        {
            var zoneOutInfo = _zoneOutInfo.First();
            return zoneOutInfo._position;
        }
    }
}
