namespace Assets.Scripts.MVC.Saved
{
    public interface IData<T>
    {
        void Save(T data, string path = null);
        T Load(string path = null);
    }
}