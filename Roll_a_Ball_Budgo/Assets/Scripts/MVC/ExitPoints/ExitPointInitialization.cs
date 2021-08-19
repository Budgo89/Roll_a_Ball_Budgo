using Assets.Scripts.MVC.Canvass;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.MVC.ExitPoints
{
    public class ExitPointInitialization : IInitialization
    {
        private readonly IExitPointFactory _exitPointFactory;
        public GameObject _exitPoint;
        private CanvasManager _canvasManager;

        public ExitPointInitialization(IExitPointFactory exitPointFactory, CanvasManager canvasManager)
        {
            _exitPointFactory = exitPointFactory;
            _canvasManager = canvasManager;
            _exitPoint = _exitPointFactory.CreateExitPoint();
            _exitPoint.GetComponent<ExitPoint>().LinkToText(SearchInCanvas("Text").GetComponent<Text>());
        }

        public void Initialization()
        {
        }
        private GameObject SearchInCanvas(string teg)
        {
            for (int i = 0; i < _canvasManager.canvasManager.Count; i++)
            {
                if (String.Equals(_canvasManager.canvasManager[i].teg, teg))
                {
                    var canvasInfo = _canvasManager.canvasManager[i]._gameObject.gameObject;
                    return canvasInfo;
                }
            }
            return null;
        }
    }
}
