using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBuf : Bonus
{
    private void OnTriggerEnter(Collider other)
    {
        speedBuf();
    }
}
