using Camada_Application.Dtos;

namespace Camada_Application.Interfaces
{
    public interface IClienteApp : IBaseApp
    {
        ClienteDto GetById(Guid ClienteId);
    }
}
