// See https://aka.ms/new-console-template for more information


using ClassLibrary1;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
        services
            .AddSingleton<IService, Service>())
    .Build();


using IServiceScope serviceScope = host.Services.CreateScope();
IServiceProvider provider = serviceScope.ServiceProvider;

var print = provider.GetRequiredService<IService>();

print.PrintConsole("Hello, World!");