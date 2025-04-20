// See https://aka.ms/new-console-template for more information

using Camada_Application.Services;
using Camada_Domain.Entities;
using Camada_Domain.Interfaces.IRepositories;
using Camada_Domain.Interfaces.IServices;
using Camada_Infra.Repositories;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello, World!");

#region Config Ioc Di

// Configurar o contêiner de serviços
var serviceCollection = new ServiceCollection();
serviceCollection.AddTransient<IClienteRepository, ClienteRepository>();
serviceCollection.AddTransient<IClienteService, ClienteService>();
var serviceProvider = serviceCollection.BuildServiceProvider();

// Resolver o contêiner de serviço
var clienteService = serviceProvider.GetService<IClienteService>();

#endregion

// Chamar o método GetAll
if (clienteService != null) // Verificar se clienteService não é nulo
{
    var clientes = clienteService.GetAll<Cliente>();
    if (clientes != null) // Verificar se clientes não é nulo
    {
        foreach (var cliente in clientes)
        {
            Console.WriteLine($"ID: {cliente.ClienteId}, Nome: {cliente.Nome}");
        }
    }
    else
    {
        Console.WriteLine("Nenhum cliente encontrado.");
    }
}
else
{
    Console.WriteLine("O serviço de cliente não foi resolvido.");
}