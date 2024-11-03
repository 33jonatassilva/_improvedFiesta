using EasyManage.Models;
using EasyManage.Data;
using Microsoft.EntityFrameworkCore;

namespace EasyManage.Controller;

    public class ClientController(AppDbContext context)
    {
        public async Task AddClientAsync(Client client)
        {
            try
            {
                if (client is null) throw new ArgumentNullException(nameof(client));

                await context.Clients.AddAsync(client);
                await context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    
    
    
    public async Task<List<Client>> ListClientsAsync()
    {
        List<Client> clients = await context.Clients.ToListAsync();
        return clients;
    }

    public async Task<Client> GetClientByIdAsync(string clientId)
        => await context.Clients.FirstOrDefaultAsync(c => c.Cpf == clientId);
    
    
    
    
    public void ClientUpdate(Guid id, Client clientUpdate)
    {
        
        Client client = context.Clients.Find(id);
        
        if (client is null)
            return;
        
        client.FirstName = clientUpdate.FirstName;
        client.LastName = clientUpdate.LastName;
        client.EClientBudgetRate = clientUpdate.EClientBudgetRate;
        
        context.Update(client);
        context.SaveChanges();
    }

    public async Task<Client> DeleteClientByIdAsync(string clientId)
    {
        
        var client = await context.Clients.FirstOrDefaultAsync(c => c.Cpf == clientId);
        context.Clients.Remove(client);

        return client;
    }
    
    
}