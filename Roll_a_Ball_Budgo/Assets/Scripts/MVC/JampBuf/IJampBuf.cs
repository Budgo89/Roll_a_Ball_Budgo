using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public interface IJampBuf
{
    event Action<int> OnTriggerEnterChange;
    void LinkToSlider(Slider slider, GameObject ball);
}
