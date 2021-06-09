using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour
{
    [SerializeField] private int vicrory = 3;
    [SerializeField] private GameObject exitPoint;

    public void VicroryСheck()
    {
        vicrory--;
        Debug.Log(vicrory);
        if (vicrory == 0)
        {
            exitPoint.SetActive(true);
        }
    }
}
