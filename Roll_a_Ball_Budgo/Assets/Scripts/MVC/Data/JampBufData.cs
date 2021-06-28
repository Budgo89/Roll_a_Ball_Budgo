using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "JampBufSettings", menuName = "Data/Unit/JampBufSettings")]
public sealed class JampBufData : ScriptableObject
{
    [Serializable] 
    private struct JampBufInfo
    {
        public JampBuf jampBufPrefab;
        public Vector3Int _position;
    }

    [SerializeField] private List<JampBufInfo> _jampBufInfo;
    public JampBuf GetJampBuf()
    {
        var jampBufInfo = _jampBufInfo.First();
        return jampBufInfo.jampBufPrefab;
    }

    public Vector3 GetJampBufPosition()
    {
        var jampBufInfo = _jampBufInfo.First();
        return jampBufInfo._position;
    }
}
