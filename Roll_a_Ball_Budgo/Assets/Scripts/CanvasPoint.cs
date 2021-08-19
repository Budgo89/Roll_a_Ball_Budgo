using UnityEngine;

public class CanvasPoint
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
