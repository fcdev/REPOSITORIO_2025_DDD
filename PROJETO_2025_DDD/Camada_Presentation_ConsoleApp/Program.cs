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


if (clienteService != null) // Verificar se clienteService não é nulo
{
    var clientes = clienteService.GetAll<Cliente>();
    if (clientes != null) 
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

    var objCliente = clienteService.GetClienteById(Guid.Parse("f34b9d97-bdf3-4561-a35f-63a68bfb9cd3"));
    if (objCliente != null) 
    {
        Console.WriteLine($"\nID: {objCliente.ClienteId}, Nome: {objCliente.Nome}");
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