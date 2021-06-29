using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISpeedBufFactory
{
    ISpeedBuf CreateSpeedBuf(int i);
    int SpeedBufCount();
    // void FalseSlider();
}
