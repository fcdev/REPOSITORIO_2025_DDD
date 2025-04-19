namespace Camada_Domain.Interfaces
{
    public interface IBaseRepository
    {
        List<T> GetAll<T>() where T : class;
    }
}
