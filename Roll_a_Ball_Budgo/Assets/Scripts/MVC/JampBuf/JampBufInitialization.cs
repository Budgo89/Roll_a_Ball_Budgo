using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal sealed class JampBufInitialization : IInitialization
{
    private readonly IJampBufFactory _jampBufFactory;
    private readonly SpeedBufData _speedBufDataCount;
    private IJampBuf _jampBuf;

    public JampBufInitialization(IJampBufFactory jampBufFactory)
    {
        _jampBufFactory = jampBufFactory;
        _jampBuf = _jampBufFactory.CreateJampBuf();

    }
    public void Initialization()
    {
    }
}
