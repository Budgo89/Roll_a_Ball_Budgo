using Assets.Scripts.MVC.MiniMapsCamera;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts.MVC.Data
{
    [CreateAssetMenu(fileName = "MiniMapCameraSettings", menuName = "Data/Unit/MiniMapCameraSettings")]
    public class MiniMapCameraData : ScriptableObject
    {
        [Serializable]
        private struct MiniMapCameraInto 
        {
            public MiniMapCamera miniMapCameraPrefab;
            public Vector3Int _position;
        }
        [SerializeField] private List<MiniMapCameraInto> _miniMapCameraInto;
        public MiniMapCamera GetMiniMapCamera()
        {
            var miniMapCameraInto = _miniMapCameraInto.First();
            return miniMapCameraInto.miniMapCameraPrefab;
        }
        public Vector3 GetMiniMapCameraPosition()
        {
            var miniMapCameraInto = _miniMapCameraInto.First();
            return miniMapCameraInto._position;
        }
    }
}
