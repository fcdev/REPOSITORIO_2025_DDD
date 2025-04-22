using Camada_Application.Dtos;
using Camada_Domain.Entities;

namespace Camada_Application.Mapping
{
    public static class MapperApp
    {
        #region ClienteMapClienteDto

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

        #endregion

        #region ClienteDtoMapCliente

        public static void ClienteDtoMapCliente(List<ClienteDto> clienteDto, out List<Cliente> cliente)
        {
            if (clienteDto == null) throw new ArgumentNullException(nameof(clienteDto));
            cliente = clienteDto.Select(dto => new Cliente(
                dto.Nome, 
                dto.ClienteId
                )).ToList();
        }

        public static void ClienteDtoMapCliente(ClienteDto clienteDto, out Cliente cliente)
        {
            if (clienteDto == null) throw new ArgumentNullException(nameof(clienteDto));
            cliente = new Cliente(
                clienteDto.Nome, 
                clienteDto.ClienteId
                );
        }

        #endregion
    }
}
