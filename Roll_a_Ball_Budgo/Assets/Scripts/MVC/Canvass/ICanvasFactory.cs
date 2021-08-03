using UnityEngine;

namespace Assets.Scripts.MVC.Canvass
{
    public interface ICanvasFactory
    {
        CanvasInterface CreareCanvas(int i);
        int CanvasCount();
        string GetCanvatTeg(int i);
    }
}