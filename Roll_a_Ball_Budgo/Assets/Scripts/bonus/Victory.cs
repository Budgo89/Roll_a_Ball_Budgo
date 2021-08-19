using UnityEngine;

public class Victory
{
    private int _pointsForVictory;
    private GameObject _exitPoint;

    public Victory(GameObject exitPoint, int pointsForVictory)
    {
        _exitPoint = exitPoint;
        _pointsForVictory = pointsForVictory;
    }

    public void VictoryСheck()
    {
        _pointsForVictory--;
        if (_pointsForVictory == 0)
        {
            _exitPoint.SetActive(true);
        }
    }
}
