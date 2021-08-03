namespace Assets.Scripts.MVC.Saved
{
    public interface ISaveDataRepository
    {
        void Save(PlayerBase player);
        void Load(PlayerBase player);
    }
}