using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.MVC.MiniMaps
{
    public class MiniMapCanvasInitialization : IInitialization
    {
        private readonly IMiniMapCanvasFactory _miniMapCanvasFactory;
        private IMiniMapCanvas _miniMapCanvas;

        public MiniMapCanvasInitialization (IMiniMapCanvasFactory mapCanvasFactory)
        {
            _miniMapCanvasFactory = mapCanvasFactory;
            _miniMapCanvas = _miniMapCanvasFactory.CreateMiniMapCanvas();
        }

        public void Initialization()
        {
        }
    }
}
