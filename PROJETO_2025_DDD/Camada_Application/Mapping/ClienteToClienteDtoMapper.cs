using Camada_Application.Dtos;
using Camada_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camada_Application.Mapping
{
    public partial class Mapper
    {
        public static void ClienteToClienteDto(List<Cliente> cliente, out List<ClienteDto> clienteDto)
        {
            if (cliente == null) throw new ArgumentNullException(nameof(cliente));
            clienteDto = cliente.Select(cliente => new ClienteDto
            {
                ClienteId = cliente.ClienteId,
                Nome = cliente.Nome
            }).ToList();
        }

        public static void ClienteToClienteDto(Cliente cliente, out ClienteDto clienteDto)
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
