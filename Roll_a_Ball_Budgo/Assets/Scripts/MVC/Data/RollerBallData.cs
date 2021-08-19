using Assets.Scripts.MVC.RollerBalls;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts.MVC.Data
{
    [CreateAssetMenu(fileName = "RollerBallSettings", menuName = "Data/Unit/RollerBallSettings")]
    public class RollerBallData : ScriptableObject
    {
        [Serializable]
        private struct RollerBallInfo
        {
            public RollerBall rollerBallPrefab;
            public Vector3Int _position;
        }
        [SerializeField] private List<RollerBallInfo> _rollerBallInfos;
        public RollerBall GetRollerBall()
        {
            var rollerBallInfo = _rollerBallInfos.First();
            return rollerBallInfo.rollerBallPrefab;
        }
        public Vector3 GetRollerBallPosition()
        {
            var rollerBallInfo = _rollerBallInfos.First();
            return rollerBallInfo._position;
        }
    }
}
