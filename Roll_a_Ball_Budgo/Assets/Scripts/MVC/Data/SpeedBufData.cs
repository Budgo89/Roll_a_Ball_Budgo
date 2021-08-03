using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SpeedBufSettings", menuName = "Data/Unit/SpeedBufSettings")]
public class SpeedBufData : ScriptableObject
{
    [Serializable]
    private struct SpeedBufInfo
    {
        public SpeedBuf speedBufPrefab;
        public Vector3Int _position;
    }

    [SerializeField] private List<SpeedBufInfo> _speedBufInfo;

    public int SpeedBufCount()
    {
        return _speedBufInfo.Count;
    }
    
    public SpeedBuf GetSpeedBuf(int i)
    {
        var speedBufInfo = _speedBufInfo[i];
        return speedBufInfo.speedBufPrefab;
    }

    public Vector3 GetSpeedBufPosition(int i)
    {
        var speedBufInfo = _speedBufInfo[i];
        return speedBufInfo._position;
    }
}
