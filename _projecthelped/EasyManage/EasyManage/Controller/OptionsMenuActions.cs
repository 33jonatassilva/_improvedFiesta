using EasyManage.Builders;
using EasyManage.Data;

namespace EasyManage.Controller;

public class OptionsMenuActions
{
    public void OptionsInitialMenu()
    {
    
    
        AppDbContext context = new AppDbContext();
        ClientController clientController = new ClientController(context);
        
        var opc = Console.ReadLine();
        

        switch (opc)
        {
            // Add
            case "1":
            
                _ = clientController.AddClientAsync(ClientBuilder.Build()); 
                break;
                
            // Update
            case "2":
            
                            
            
                break;
            
            // Remove
            case "3":

                //clientController.DeleteClientByIdAsync();
                break;
            case "4":
                break;
            case "5":
                break;
            case "6":
                break;
            default:
                break;
                
        }
    }
}