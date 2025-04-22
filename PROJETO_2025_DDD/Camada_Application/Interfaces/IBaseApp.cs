namespace Camada_Application.Interfaces
{
    public interface IBaseApp
    {
        List<T> GetAll<T>() where T : class;
    }
}
