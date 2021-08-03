using UnityEngine;

namespace Assets.Scripts.MVC.RollerBalls
{
    public interface IRollerBallFactory
    {
        GameObject CreateRollerBall();
    }
}