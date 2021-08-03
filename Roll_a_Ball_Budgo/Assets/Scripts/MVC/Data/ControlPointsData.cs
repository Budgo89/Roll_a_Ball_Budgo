using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.MVC.Data
{
    [CreateAssetMenu(fileName = "ControlPointsSettings", menuName = "Data/Unit/ControlPointsSettings")]
    public class ControlPointsData : ScriptableObject
    {
        [Serializable]
        private struct ControlPointsInfo
        {            
            public ControlPoints controlPointsPrefab;
            public Vector3Int _position;
        }

        [SerializeField] private List<ControlPointsInfo> _controlPointsInfo;

        public int ControlPointsCount()
        {
            return _controlPointsInfo.Count;
        }

        public ControlPoints GetControlPoints(int i)
        {
            var controlPointsInfo = _controlPointsInfo[i];
            return controlPointsInfo.controlPointsPrefab;
        }

        public Vector3 GetControlPointPosition(int i)
        {
            var controlPointsInfo = _controlPointsInfo[i];
            return controlPointsInfo._position; 
        }
    }
}
