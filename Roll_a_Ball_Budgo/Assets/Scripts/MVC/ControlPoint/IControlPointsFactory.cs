namespace Assets.Scripts.MVC.ControlPoint
{
    public interface IControlPointsFactory
    {
        IControlPoints CreareControlPoints(int i);
        int ControlPointsCount();
    }
}