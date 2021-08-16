using Assets.Scripts.MVC.Data;
using UnityEngine;

namespace Assets.Scripts.MVC.ZoneOuts
{
    public class ZoneOutFactor : IZoneOutFactor
    {

        private readonly ZoneOutData _zoneOutData;

        public ZoneOutFactor(ZoneOutData zoneOutData)
        {
            _zoneOutData = zoneOutData;
        }

        public IZoneOut CreateZoneOut()
        {
            var zoneOut = _zoneOutData.GetZoneOut();
            var zoneOutPosition = _zoneOutData.GetZoneOutPosition();
            return Object.Instantiate(zoneOut,zoneOutPosition, Quaternion.identity);
        }
    }
}
