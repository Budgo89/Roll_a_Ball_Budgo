using Assets.Scripts.MVC.Data;
using UnityEngine;

namespace Assets.Scripts.MVC.MiniMaps
{
    public class MiniMapCanvasFactory : IMiniMapCanvasFactory
    {
        private readonly MiniMapCanvasData _miniMapCanvasData;
        public MiniMapCanvasFactory(MiniMapCanvasData miniMapCanvasData)
        {
            _miniMapCanvasData = miniMapCanvasData;
        }

        public IMiniMapCanvas CreateMiniMapCanvas()
        {
            var miniMapCanvas = _miniMapCanvasData.GetMiniMapCanvas();
            var miniMapCanvasPosition = _miniMapCanvasData.GetMiniMapCanvasPosition();
            return Object.Instantiate(miniMapCanvas, miniMapCanvasPosition, Quaternion.identity);
        }
    }
}
