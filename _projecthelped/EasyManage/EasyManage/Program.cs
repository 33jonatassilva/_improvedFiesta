

using System.Globalization;
using EasyManage.Data;
using EasyManage.Models;
using EasyManage.Repositories;
using EasyManage.Services;
using EasyManage.View;
using Microsoft.Extensions.DependencyInjection;

namespace EasyManage;

class Program
{
    static void Main(string[] args)
    {
        
        
        var serviceCollection = new ServiceCollection();
        
        ConfigureServices(serviceCollection);
        
        var serviceProvider = serviceCollection.BuildServiceProvider();

        var menu = serviceProvider.GetService<IOptionsMenuActions>();
        
       if (menu != null) menu.OptionsInitialMenu();

        static void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>()
                .AddScoped<IClientRepository, ClientRepository>()
                .AddScoped<IClientService, ClientService>()
                .AddScoped<IOptionsMenuActions, OptionsMenuActions>();
        }
    }
}