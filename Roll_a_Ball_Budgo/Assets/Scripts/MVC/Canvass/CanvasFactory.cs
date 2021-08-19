using Assets.Scripts.MVC.Data;
using System;
using UnityEngine;

namespace Assets.Scripts.MVC.Canvass
{
    public class CanvasFactory : ICanvasFactory
    {
        private readonly CanvasData _canvasData;
        private Transform _parent;        

        public CanvasFactory(CanvasData canvasData)
        {
            _canvasData = canvasData;
            
        }

        public int CanvasCount()
        {
            return _canvasData.CanvasCount();
        }

        public CanvasInterface CreareCanvas(int i)
        {
            var canvas = _canvasData.GetCanvas(i);
            var canvasPositions = _canvasData.GetCanvasPositions(i);
            var odject = GameObject.Instantiate(canvas, canvasPositions, Quaternion.identity);
            if (i == 0)
            {
                _parent = odject.transform;
            }
            else
            {
                odject.transform.parent = _parent;
                odject.GetComponent<RectTransform>().anchoredPosition3D = canvasPositions;
            }

            return odject;
        }
        public string GetCanvatTeg(int i)
        {
            return _canvasData.GetCanvatTeg(i);
        }
    }
}
