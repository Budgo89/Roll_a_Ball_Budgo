using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISpeedBuf
{
    event Action<int> OnTriggerEnterChange;
    void FalseSlider();
}
