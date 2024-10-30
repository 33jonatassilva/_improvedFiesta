using Azure.Identity;
using EasyManage.Entities;
using EasyManage.Data;
using Microsoft.EntityFrameworkCore;

namespace EasyManage.Controller;

public class ClientController (AppDbContext context)
{

    public async Task<Client> AddClient(Client client)
    {
        if (client is null) throw new ArgumentNullException(nameof(client));
        await context.Clients.AddAsync(client);
        await context.SaveChangesAsync();

        return  client;
    }
    
    
    public async Task<List<Client>> ListClientsAsync()
    {
        List<Client> clients = await context.Clients.ToListAsync();
        return clients;
    }

    public async Task<Client> GetClientByIdAsync(Guid clientId)
        => await context.Clients.FirstOrDefaultAsync(c => c.Id == clientId);
    
    
    
    
    public void ClientUpdate(Guid id, Client clientUpdate)
    {
        
        Client client = context.Clients.Find(id);
        
        if (client is null)
            return;
        
        client.FirstName = clientUpdate.FirstName;
        client.LastName = clientUpdate.LastName;
        client.ClientBudgetRate = clientUpdate.ClientBudgetRate;
        
        context.Update(client);
        context.SaveChanges();
    }

    public async Task<Client> DeleteClientByIdAsync(Guid clientId)
    {
        var client = await context.Clients.FirstOrDefaultAsync(c => c.Id == clientId);
        context.Clients.Remove(client);

        return client;
    }
    
    
}