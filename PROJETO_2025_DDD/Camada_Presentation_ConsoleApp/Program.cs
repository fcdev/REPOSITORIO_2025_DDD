// See https://aka.ms/new-console-template for more information

using Camada_Application.Dtos;
using Camada_Application.Interfaces;
using Camada_Application.Services;
using Camada_Domain.Interfaces.IRepositories;
using Camada_Domain.Interfaces.IServices;
using Camada_Domain.Services;
using Camada_Infra.Repositories;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello, World!");

#region Config Ioc Di

// Configurar o contêiner de serviços
var serviceCollection = new ServiceCollection();
serviceCollection.AddTransient<IClienteRepository, ClienteRepository>();
serviceCollection.AddTransient<IClienteService, ClienteService>();
serviceCollection.AddTransient<IClienteApp, ClienteApp>();
var serviceProvider = serviceCollection.BuildServiceProvider();

// Resolver o contêiner de serviço
var clienteApp = serviceProvider.GetService<IClienteApp>();

#endregion

#region Camada_Application

if (clienteApp != null) // Verificar se clienteService não é nulo
{
    var clientes = clienteApp.GetAll<ClienteDto>();
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

    var objCliente = clienteApp.GetById(Guid.Parse("f34b9d97-bdf3-4561-a35f-63a68bfb9cd3"));
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

#endregion