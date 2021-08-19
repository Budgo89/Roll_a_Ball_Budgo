﻿using Assets.Scripts.MVC.Data;
using UnityEngine;

namespace Assets.Scripts.MVC.MiniMapsCamera
{
    public class MiniMapCameraFactory : IMiniMapCameraFactory
    {
        private readonly MiniMapCameraData _miniMapCameraData;
        public MiniMapCameraFactory(MiniMapCameraData miniMapCameraData)
        {
            _miniMapCameraData = miniMapCameraData;
        }

        public MiniMapCamera CreateMiniMapCamera()
        {
            var miniMapCamera = _miniMapCameraData.GetMiniMapCamera();
            var miniMapCameraPosition = _miniMapCameraData.GetMiniMapCameraPosition();
            return Object.Instantiate(miniMapCamera, miniMapCameraPosition, Quaternion.identity);
        }
    }
}