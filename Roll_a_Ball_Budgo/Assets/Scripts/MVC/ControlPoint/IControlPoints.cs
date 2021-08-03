using System;

public interface IControlPoints
{
    event Action<int> OnTriggerEnterChange;
    void LinkToVictoryAndCanvasPoint(Victory victory, CanvasPoint canvasPoint);
}