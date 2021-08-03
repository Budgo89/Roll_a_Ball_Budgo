using UnityEngine;

namespace Assets.Scripts.MVC.ExitPoints
{
    public interface IExitPointFactory
    {
        GameObject CreateExitPoint();
    }
}