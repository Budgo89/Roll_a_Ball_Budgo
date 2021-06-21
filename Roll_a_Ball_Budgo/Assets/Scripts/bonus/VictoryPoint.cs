using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryPoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        try
        {
            var enemu = other.GetComponent<Victory>();
            var cam = other.GetComponent<CanvasPoint>();
            enemu.VictoryСheck();
            cam.ImagePoint();
            gameObject.SetActive(false);
        }
        catch (Exception)
        {
            Debug.Log("GetComponent отсутствуеть на объёекте");
        }

    }
}
