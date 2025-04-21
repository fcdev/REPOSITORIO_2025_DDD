using Camada_Domain.Entities;
using Camada_Domain.Interfaces.IRepositories;
using Camada_Domain.Interfaces.IServices;

namespace Camada_Domain.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public List<T> GetAll<T>() where T : class
        {
            return _clienteRepository.GetAll<T>();
        }

        public Cliente GetClienteById(Guid clienteID)
        {
            Cliente model = _clienteRepository.GetClienteById(clienteID);
            model.AlterarNome(model.Nome?.ToUpper());
            return model;
        }
    }
}
