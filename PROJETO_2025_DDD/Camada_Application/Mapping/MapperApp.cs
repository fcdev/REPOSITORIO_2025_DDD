using Camada_Application.Dtos;
using Camada_Domain.Entities;

namespace Camada_Application.Mapping
{
    public static class MapperApp
    {
        public static void ClienteMapClienteDto(List<Cliente> cliente, out List<ClienteDto> clienteDto)
        {
            if (cliente == null) throw new ArgumentNullException(nameof(cliente));
            clienteDto = cliente.Select(cliente => new ClienteDto
            {
                ClienteId = cliente.ClienteId,
                Nome = cliente.Nome
            }).ToList();
        }

        public static void ClienteMapClienteDto(Cliente cliente, out ClienteDto clienteDto)
        {
            if (cliente == null) throw new ArgumentNullException(nameof(cliente));
            clienteDto = new ClienteDto
            {
                ClienteId = cliente.ClienteId,
                Nome = cliente.Nome
            };
        }
    }
}
