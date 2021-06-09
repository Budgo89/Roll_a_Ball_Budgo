using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryPoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var enemu = other.GetComponent<Victory>();
        enemu.VicroryСheck();
        gameObject.SetActive(false);
    }
}
