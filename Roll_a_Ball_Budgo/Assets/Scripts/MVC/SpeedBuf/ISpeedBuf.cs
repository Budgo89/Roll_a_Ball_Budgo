using System;
using UnityEngine;
using UnityEngine.UI;

public interface ISpeedBuf
{
    event Action<int> OnTriggerEnterChange;
    void FalseSlider();
    void LinkToSliderBuf(Slider sliderBuf, Slider sliderDeBuf, GameObject ball);
}
