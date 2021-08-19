using System;
using UnityEngine;

public class ControlPoints : MonoBehaviour , IControlPoints
{
    public event Action<int> OnTriggerEnterChange;
    private Victory _victory;
    private CanvasPoint _canvasPoint;

    public void LinkToVictoryAndCanvasPoint(Victory victory, CanvasPoint canvasPoint)
    {
        _victory = victory;
        _canvasPoint = canvasPoint;
    }

    private void OnTriggerEnter(Collider other)
    {
        try
        { 
            _victory.VictoryСheck();
            _canvasPoint.ImagePoint();
            gameObject.SetActive(false);
        }
        catch (Exception)
        {
            Debug.Log("GetComponent отсутствуеть на объекте");
        }

    }
}
