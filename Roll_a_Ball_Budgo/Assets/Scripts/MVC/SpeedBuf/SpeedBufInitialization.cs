using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBufInitialization : IInitialization
{
    private readonly ISpeedBufFactory _speedBufFactory;
    private ISpeedBuf _speedBuf;

    public SpeedBufInitialization(ISpeedBufFactory speedBufFactory)
    {
        _speedBufFactory = speedBufFactory;
        for (int i = 0; i < _speedBufFactory.SpeedBufCount(); i++)
        {
            _speedBuf = _speedBufFactory.CreateSpeedBuf(i);
        }

        _speedBuf.FalseSlider();
    }
    public void Initialization()
    {
    }
}
