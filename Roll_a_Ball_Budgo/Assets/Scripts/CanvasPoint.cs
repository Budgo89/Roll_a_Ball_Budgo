using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasPoint : MonoBehaviour
{
    [SerializeField] private Image[] points;
    private int _point;

    private void Awake()
    {
        _point = points.Length-1;
    }

    public void ImagePoint()
    {
        points[_point].gameObject.SetActive(false);
        _point--;
    }
    
}
