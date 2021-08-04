using Assets.Scripts.MVC.RollerBalls;

namespace Assets.Scripts.MVC.Saved
{
    public interface ISaveDataRepository
    {
        void Save(RollerBall player);
        void Load(RollerBall player);
    }
}