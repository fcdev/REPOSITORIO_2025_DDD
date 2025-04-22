using Camada_Application.Dtos;
using Camada_Application.Interfaces;
using Camada_Application.Mapping;
using Camada_Domain.Entities;
using Camada_Domain.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camada_Application.Services
{
    public class ClienteApp : IClienteApp
    {
        private readonly IClienteService _clienteService;
        public ClienteApp(IClienteService clienteService)
        {
            _clienteService = clienteService ?? throw new ArgumentNullException(nameof(clienteService));
        }

        public List<T> GetAll<T>() where T : class
        {
            var cliente = _clienteService.GetAll<Cliente>();
            if (cliente == null) throw new InvalidOperationException("Não pode ser nula.");
            MapperApp.ClienteMapClienteDto(cliente, out List<ClienteDto> clienteDto);
            return clienteDto as List<T> ?? throw new InvalidOperationException("Erro ao converter para o tipo genérico.");
        }

        public ClienteDto GetById(Guid ClienteId)
        {
            var cliente = _clienteService.GetById(ClienteId);
            if (cliente == null) throw new InvalidOperationException("Não pode ser nula.");
            MapperApp.ClienteMapClienteDto(cliente, out ClienteDto clienteDto);
            return clienteDto;
        }
    }
}
