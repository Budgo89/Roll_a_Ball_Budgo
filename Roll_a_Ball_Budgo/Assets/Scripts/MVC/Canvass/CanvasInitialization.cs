namespace Assets.Scripts.MVC.Canvass
{
    class CanvasInitialization : IInitialization
    {
        private readonly ICanvasFactory _canvasFactory;
        private CanvasInterface _canvasInterface;
        private CanvasManager _canvasManager;
        private CanvasModel canvasModel;

        public CanvasInitialization(ICanvasFactory canvasFactory, CanvasManager canvasManager)
        {
            _canvasFactory = canvasFactory;
            _canvasManager = canvasManager;
            
            for (int i = 0; i < _canvasFactory.CanvasCount(); i++)
            {
                _canvasInterface = _canvasFactory.CreareCanvas(i);
                canvasModel = new CanvasModel
                {
                    _gameObject = _canvasInterface,
                    teg = _canvasFactory.GetCanvatTeg(i)

                };
                _canvasManager.canvasManager.Add(canvasModel);
            }
        }

        public void Initialization()
        {
        }
    }
}
