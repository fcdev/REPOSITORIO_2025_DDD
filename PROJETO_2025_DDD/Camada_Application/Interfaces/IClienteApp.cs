﻿using Camada_Application.Dtos;

namespace Camada_Application.Interfaces
{
    public interface IClienteApp
    {
        List<ClienteDto> GetAll();
        ClienteDto GetById(Guid ClienteId);
    }
}
