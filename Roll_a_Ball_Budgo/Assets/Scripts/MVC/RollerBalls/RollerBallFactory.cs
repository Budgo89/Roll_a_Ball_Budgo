using Assets.Scripts.MVC.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public GameObject CreateRollerBall()
        {
            var rollerBall = _rollerBallData.GetRollerBall();
            var rollerBallPosition = _rollerBallData.GetRollerBallPosition();
            return GameObject.Instantiate(rollerBall,rollerBallPosition,Quaternion.identity).gameObject;
        }
    }
}

