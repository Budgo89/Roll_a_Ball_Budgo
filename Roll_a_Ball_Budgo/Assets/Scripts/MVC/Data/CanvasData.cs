using Assets.Scripts.MVC.Canvass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.MVC.Data
{
    [CreateAssetMenu(fileName = "CanvasSettings", menuName = "Data/Unit/CanvasSettings")]
    public class CanvasData : ScriptableObject
    {
        [Serializable]
        private struct CanvasInfo
        {
            public CanvasInterface CanvasPrefab;
            public string teg;
            public Vector3Int positions;
        }

        [SerializeField] private List<CanvasInfo> _canvasInfo;

        public int CanvasCount()
        {
            return _canvasInfo.Count;
        }
        public CanvasInterface GetCanvas(int i)
        {
            var canvasInfo = _canvasInfo[i];
            return canvasInfo.CanvasPrefab;
        }
        public Vector3 GetCanvasPositions(int i)
        {
            var canvasInfo = _canvasInfo[i];
            return canvasInfo.positions;
        }
        public string GetCanvatTeg(int i)
        {
            return _canvasInfo[i].teg;
        }
    }
}
