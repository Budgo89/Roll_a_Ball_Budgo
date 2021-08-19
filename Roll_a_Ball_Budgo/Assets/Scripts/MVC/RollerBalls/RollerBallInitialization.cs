namespace Assets.Scripts.MVC.RollerBalls
{
    public class RollerBallInitialization : IInitialization
    {

        private readonly IRollerBallFactory _rollerBallFactory;
        public RollerBall _rollerBall;

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
