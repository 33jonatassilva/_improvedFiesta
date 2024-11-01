

using EasyManage.Builders;
using EasyManage.Controller;
using EasyManage.Data;

namespace EasyManage;

class Program
{
    static async Task Main(string[] args)
    {
        AppDbContext db = new AppDbContext();
        ClientController clientController = new ClientController(db);


        clientController.AddClientAsync(ClientBuilder.Build());

    }
}