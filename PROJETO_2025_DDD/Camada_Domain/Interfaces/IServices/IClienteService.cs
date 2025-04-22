using Camada_Domain.Entities;

namespace Camada_Domain.Interfaces.IServices
{
    public interface IClienteService : IBaseService
    {
        Cliente GetById(Guid clienteID);
    }
}
