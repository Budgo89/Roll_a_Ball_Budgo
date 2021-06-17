using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour
{
    [SerializeField] private int pointsForVictory = 3;
    [SerializeField] private GameObject exitPoint;

    public void VictoryСheck()
    {
        pointsForVictory--;
        if (pointsForVictory == 0)
        {
            exitPoint.SetActive(true);
        }
    }
}
