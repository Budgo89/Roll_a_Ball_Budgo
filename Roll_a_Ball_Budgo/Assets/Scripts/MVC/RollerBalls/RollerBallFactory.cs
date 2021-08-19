using Assets.Scripts.MVC.Data;
using UnityEngine;

namespace Assets.Scripts.MVC.RollerBalls
{
    public class RollerBallFactory : IRollerBallFactory
    {
        private readonly RollerBallData _rollerBallData;

        public RollerBallFactory(RollerBallData rollerBallData)
        {
            _rollerBallData = rollerBallData;
        }

        public RollerBall CreateRollerBall()
        {
            var rollerBall = _rollerBallData.GetRollerBall();
            var rollerBallPosition = _rollerBallData.GetRollerBallPosition();
            return Object.Instantiate(rollerBall,rollerBallPosition,Quaternion.identity);
        }
    }
}

