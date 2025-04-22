using Camada_Application.Dtos;
using Camada_Domain.Entities;

namespace Camada_Application.Mapping
{
    public partial class Mapper
    {
        public static void ClienteDtoToCliente(List<ClienteDto> clienteDto, out List<Cliente> cliente)
        {
            if (clienteDto == null) throw new ArgumentNullException(nameof(clienteDto));
            cliente = clienteDto.Select(dto => new Cliente(
                dto.Nome,
                dto.ClienteId
                )).ToList();
        }

        public static void ClienteDtoToCliente(ClienteDto clienteDto, out Cliente cliente)
        {
            if (clienteDto == null) throw new ArgumentNullException(nameof(clienteDto));
            cliente = new Cliente(
                clienteDto.Nome,
                clienteDto.ClienteId
                );
        }
    }
}
