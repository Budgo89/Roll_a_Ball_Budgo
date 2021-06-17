using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedBuf : Bonus
{
    [SerializeField] private Slider _slider;
    private void OnTriggerEnter(Collider other)
    {
        if (_bufOn == false)
        {
            SpeedBuf();
            TimeBuf(_slider);
        }

    }
}
