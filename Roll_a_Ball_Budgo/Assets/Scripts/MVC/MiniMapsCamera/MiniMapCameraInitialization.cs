using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.MVC.MiniMapsCamera
{
    class MiniMapCameraInitialization : IInitialization
    {
        private readonly IMiniMapCameraFactory _miniMapCameraFactory;
        public MiniMapCamera _miniMapCamera;

        public MiniMapCameraInitialization(IMiniMapCameraFactory miniMapCameraFactory)
        {
            _miniMapCameraFactory = miniMapCameraFactory;
            _miniMapCamera = _miniMapCameraFactory.CreateMiniMapCamera();
        }

        public void Initialization()
        {
        }
    }
}
