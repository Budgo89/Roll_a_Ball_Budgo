namespace Assets.Scripts.MVC.Locations
{
    class LocationInitialization : IInitialization
    {
        private readonly ILocationFactory _locationFactory;
        private ILocation _location;

        public LocationInitialization(ILocationFactory locationFactory)
        {
            _locationFactory = locationFactory;
            _location = _locationFactory.CreateLocation();
        }

        public void Initialization()
        {            
        }
    }
}

