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
            _clienteRepository = clienteRepository ?? throw new ArgumentNullException(nameof(clienteRepository));
        }

        public List<T> GetAll<T>() where T : class
        {
            return _clienteRepository.GetAll<T>();
        }

        public Cliente GetById(Guid clienteID)
        {
            Cliente model = _clienteRepository.GetById(clienteID);
            model.AlterarNome(model.Nome?.ToUpper()); // Regra de negócio: Nome deve ser em maiúsculas
            return model;
        }
    }
}
