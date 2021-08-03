using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.MVC.RollerBalls
{
    public class RollerBallInitialization : IInitialization
    {

        private readonly IRollerBallFactory _rollerBallFactory;
        public GameObject _rollerBall;

        public RollerBallInitialization(IRollerBallFactory rollerBallFactory) 
        {
            _rollerBallFactory = rollerBallFactory;
            _rollerBall = _rollerBallFactory.CreateRollerBall();
        }

        public void Initialization()
        {            
        }
        
    }
}
