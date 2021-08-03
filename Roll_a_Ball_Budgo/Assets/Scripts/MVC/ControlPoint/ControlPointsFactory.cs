using Assets.Scripts.MVC.Data;
using UnityEngine;

namespace Assets.Scripts.MVC.ControlPoint
{
    public class ControlPointsFactory : IControlPointsFactory
    {
        private readonly ControlPointsData _controlPointsData;

        public ControlPointsFactory(ControlPointsData controlPointsData)
        {
            _controlPointsData = controlPointsData;
        }

        public int ControlPointsCount()
        {
            return _controlPointsData.ControlPointsCount();
        }

        public IControlPoints CreareControlPoints(int i)
        {
            var controlPoints = _controlPointsData.GetControlPoints(i);
            var controlPointsPosition = _controlPointsData.GetControlPointPosition(i);
            return Object.Instantiate(controlPoints, controlPointsPosition, Quaternion.identity);
        }
    }
}
