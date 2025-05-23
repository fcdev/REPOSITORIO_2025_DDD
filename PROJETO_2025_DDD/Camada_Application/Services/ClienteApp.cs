﻿using Camada_Application.Dtos;
using Camada_Application.Interfaces;
using Camada_Application.Mapping;
using Camada_Domain.Entities;
using Camada_Domain.Interfaces.IServices;

namespace Camada_Application.Services
{
    public class ClienteApp : IClienteApp
    {
        private readonly IClienteService _clienteService;
        public ClienteApp(IClienteService clienteService)
        {
            _clienteService = clienteService ?? throw new ArgumentNullException(nameof(clienteService));
        }

        public List<ClienteDto> GetAll()
        {
            List<Cliente> cliente = _clienteService.GetAll<Cliente>();
            if (cliente == null) throw new InvalidOperationException("Não pode ser nula.");
            Mapper.ClienteToClienteDto(cliente, out List<ClienteDto> clienteDto);
            return clienteDto;
        }

        public ClienteDto GetById(Guid ClienteId)
        {
            Cliente cliente = _clienteService.GetById(ClienteId);
            if (cliente == null) throw new InvalidOperationException("Não pode ser nula.");
            Mapper.ClienteToClienteDto(cliente, out ClienteDto clienteDto);
            return clienteDto;
        }
    }
}
