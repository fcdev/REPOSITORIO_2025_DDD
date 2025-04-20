namespace Camada_Domain.Interfaces
{
    public interface IBaseService
    {
        List<T> GetAll<T>() where T : class;
    }
}
