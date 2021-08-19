using Assets.Scripts.MVC.RollerBalls;
using System;
using UnityEngine.UI;

public interface IJampBuf
{
    event Action<int> OnTriggerEnterChange;
    void LinkToSlider(Slider slider, RollerBall ball);
}
