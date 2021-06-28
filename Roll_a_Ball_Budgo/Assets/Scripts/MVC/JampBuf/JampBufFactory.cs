using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JampBufFactory : IJampBufFactory
{
    private readonly JampBufData _jampBufData;

    public JampBufFactory(JampBufData jampBufdata)
    {
        _jampBufData = jampBufdata;
    }
        
    public IJampBuf CreateJampBuf()
    {
        var jampBuf = _jampBufData.GetJampBuf();
        var jampBufPosition = _jampBufData.GetJampBufPosition();
        return Object.Instantiate(jampBuf,jampBufPosition,Quaternion.identity);
    }
}


