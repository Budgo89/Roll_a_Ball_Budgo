using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.MVC.Data
{
    [CreateAssetMenu(fileName = "ExitPointSettings", menuName = "Data/Unit/ExitPointSettings")]
    public sealed class ExitPointData : ScriptableObject
    {
        [Serializable]
        private struct ExitPointInfo
        {
            public ExitPoint exitPointPrefab;
            public Vector3Int _position;
        }
        [SerializeField] private List<ExitPointInfo> _exitPointInfo;

        public ExitPoint GetExitPoint()
        {
            var jampBufInfo = _exitPointInfo.First();
            return jampBufInfo.exitPointPrefab;
        }

        public Vector3 GetExitPointPosition()
        {
            var jampBufInfo = _exitPointInfo.First();
            return jampBufInfo._position;
        }
    }
}
