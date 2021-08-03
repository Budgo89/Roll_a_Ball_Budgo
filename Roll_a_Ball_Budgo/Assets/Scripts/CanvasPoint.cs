using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasPoint /*: MonoBehaviour*/
{
    private GameObject[] _points;
    private int _point;

    public CanvasPoint(GameObject[] points)
    {
        _points = points;
        _point = _points.Length-1;
    }

    public void ImagePoint()
    {
        _points[_point].gameObject.SetActive(false);
        _point--;
    }
    
}
