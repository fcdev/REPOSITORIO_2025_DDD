﻿using Camada_Domain.Entities;

namespace Camada_Domain.Interfaces.IRepositories
{
    public interface IClienteRepository : IBaseRepository
    {
        Cliente GetById(Guid clienteId);
    }
}
