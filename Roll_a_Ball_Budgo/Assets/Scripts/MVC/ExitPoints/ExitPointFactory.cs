using Assets.Scripts.MVC.Data;
using UnityEngine;

namespace Assets.Scripts.MVC.ExitPoints
{
    public class ExitPointFactory : IExitPointFactory
    {
        private readonly ExitPointData _exitPointData;

        public ExitPointFactory(ExitPointData exitPointData)
        {
            _exitPointData = exitPointData;
        }

        public GameObject CreateExitPoint()
        {
            var exitPoint = _exitPointData.GetExitPoint();
            var exitPointPosition = _exitPointData.GetExitPointPosition();
            return GameObject.Instantiate(exitPoint,exitPointPosition, Quaternion.identity).gameObject;
        }
    }
}

