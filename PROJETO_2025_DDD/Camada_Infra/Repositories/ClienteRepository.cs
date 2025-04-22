using Camada_Domain.Entities;
using Camada_Domain.Interfaces.IRepositories;

namespace Camada_Infra.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        public List<T> GetAll<T>() where T : class => _cliente.Cast<T>().ToList();

        public Cliente GetById(Guid clienteId) => _cliente.FirstOrDefault(c => c.ClienteId == clienteId) ?? throw new InvalidOperationException("Não encontrado.");

        #region Simulador de Banco de Dados  

        private static List<Cliente> _cliente = new List<Cliente>
        {
            new Cliente("Cliente 1", Guid.Parse("425626ea-65aa-4f4e-ac81-cbfe71a3f311")),
            new Cliente("Cliente 2", Guid.Parse("f34b9d97-bdf3-4561-a35f-63a68bfb9cd3")),
            new Cliente("Cliente 3", Guid.Parse("c84319e3-a5cc-409f-9fb6-1b67ea6e7feb"))
        };

        #endregion
    }
}
