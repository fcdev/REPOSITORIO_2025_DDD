using Camada_Domain.Entities;
using Camada_Domain.Interfaces;
using Camada_Domain.Interfaces.IRepositories;

namespace Camada_Infra.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        public List<T> GetAll<T>() where T : class => _cliente.Cast<T>().ToList();

        public Cliente GetClienteById(Guid clienteId) => _cliente.FirstOrDefault(c => c.ClienteId == clienteId) ?? throw new InvalidOperationException("Não encontrado.");

        #region Simulador de Banco de Dados  

        private static List<Cliente> _cliente = new List<Cliente>
        {
            new Cliente("Cliente 1", Guid.NewGuid()),
            new Cliente("Cliente 2", Guid.NewGuid()),
            new Cliente("Cliente 3", Guid.NewGuid())
        };

        #endregion
    }
}
