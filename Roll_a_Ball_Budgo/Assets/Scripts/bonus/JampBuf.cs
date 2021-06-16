using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JampBuf : Bonus
{
    [SerializeField] private Slider _slider;
    private void OnTriggerEnter(Collider other)
    {
        if (_bufOn == false)
        {
            JampBuf();
            TimeBuf(_slider);
        }

    }
}
