using Assets.Scripts.MVC.MiniMaps;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts.MVC.Data
{
    [CreateAssetMenu(fileName = "MiniMapCanvasSettings", menuName = "Data/Unit/MiniMapCanvasSettings")]
    public class MiniMapCanvasData : ScriptableObject
    {
        [Serializable]
        private struct MiniMapCanvasInfo
        {
            public MiniMapCanvas miniMapCanvasPrefab;
            public Vector3Int _position;
        }
        [SerializeField] private List<MiniMapCanvasInfo> _miniMapCanvasInfos;
        public MiniMapCanvas GetMiniMapCanvas()
        {
            var miniMapCanvasInfo = _miniMapCanvasInfos.First();
            return miniMapCanvasInfo.miniMapCanvasPrefab;
        }
        public Vector3 GetMiniMapCanvasPosition()
        {
            var miniMapCanvasInfo = _miniMapCanvasInfos.First();
            return miniMapCanvasInfo._position;
        }
    }
}
