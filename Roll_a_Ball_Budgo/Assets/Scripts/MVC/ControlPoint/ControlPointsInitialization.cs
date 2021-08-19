using Assets.Scripts.MVC.Canvass;
using System;
using UnityEngine;

namespace Assets.Scripts.MVC.ControlPoint
{
    class ControlPointsInitialization : IInitialization
    {
        private readonly IControlPointsFactory _controlPointsFactory;
        private IControlPoints _controlPoints;
        private Victory _victory;
        private CanvasManager _canvasManager;

        public ControlPointsInitialization(IControlPointsFactory controlPointsFactory, Victory victory, CanvasManager canvasManager)
        {
            _controlPointsFactory = controlPointsFactory;
            _victory = victory;
            _canvasManager = canvasManager;
            var gameObjectMas = SearchInCanvasPoint(new string[] { "PointExit", "Point1", "Point2", "Point3" });
            var canvasPoint = new CanvasPoint(gameObjectMas);
            for (int i = 0; i < _controlPointsFactory.ControlPointsCount(); i++)
            {
                _controlPoints = _controlPointsFactory.CreareControlPoints(i);
                _controlPoints.LinkToVictoryAndCanvasPoint(_victory, canvasPoint);
            }

        }

        public void Initialization()
        {
            
        }
        public GameObject[] SearchInCanvasPoint(string[] teg)
        {
            var gameObjectMas = new GameObject[teg.Length];
            for (int i = 0; i < teg.Length; i++)
            {
                for (int j = 0; j < _canvasManager.canvasManager.Count; j++)
                {
                    if (String.Equals(_canvasManager.canvasManager[j].teg, teg[i]))
                    {
                        gameObjectMas[i] = _canvasManager.canvasManager[j]._gameObject.gameObject;
                        
                    }
                }
            }
            return gameObjectMas;
        }
    }
}
