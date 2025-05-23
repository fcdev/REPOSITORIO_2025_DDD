﻿namespace Camada_Domain.Entities
{
    public class Cliente
    {
        public Cliente() { }
        public Cliente(string? nome, Guid? clienteId = null)
        {
            Nome = nome;
            ClienteId = clienteId ?? Guid.NewGuid();
        }

        public Guid? ClienteId { get; private set; }
        public string? Nome { get; private set; }

        public void AlterarNome(string? nome)
        {
            Nome = nome;
        }
    }
}
