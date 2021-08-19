namespace Assets.Scripts.MVC.ZoneOuts
{
    class ZoneOutInitialization : IInitialization
    {
        private readonly IZoneOutFactor _zoneOutFactory;
        private IZoneOut _zoneOut;

        public ZoneOutInitialization(IZoneOutFactor zoneOutFactor)
        {
            _zoneOutFactory = zoneOutFactor;
            _zoneOut = _zoneOutFactory.CreateZoneOut();
        }

        public void Initialization()
        {
        }
    }
}
