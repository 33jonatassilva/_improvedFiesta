
using System.Globalization;
using EasyManage.Models;
using EasyManage.Services;
namespace EasyManage.View;




public class OptionsMenuActions : IOptionsMenuActions
{
    private readonly IClientService _clientService;

    public OptionsMenuActions(IClientService clientService)
    {
        _clientService = clientService;
    }

   
    public async void OptionsInitialMenu()
    {


        Print.MenuOptionInitial();
        
        var optionSelected = Console.ReadLine();

        switch (optionSelected)
        {
            case "1":
            
                var client = new Client
                {
                    FirstName = "Jonatas",
                    LastName = "Jones",
                    Cpf = "000.000.000-00",
                    BirthDate = DateTime.ParseExact("18/04/2003", "dd/MM/yyyy", CultureInfo.InvariantCulture )
                };

                _clientService.AddClient(client);
                
                break;
                
            case "2":
                var clients = _clientService.GetAllClients();
                
                foreach (var item in clients)
                {
                    Console.WriteLine(item.ToString());
                }
                
                break;
            
            case "3":
                break;
            
            case "4":
                break;
            
            case "5":
                break;
            
            default:
                break;
            
            
            
        }
        


    }
}