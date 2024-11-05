using EasyManage.Data;
using EasyManage.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyManage.Repositories;

public class ClientRepository : IClientRepository
{
    private readonly AppDbContext _context;

    public ClientRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Task> AddClientAsync(Client client)
    {
        await _context.Clients.AddAsync(client);
        await _context.SaveChangesAsync();
        
        return Task.CompletedTask;
    }
    
    
    public async Task<List<Client>> GetAllClientsAsync()
    {
        return await _context.Clients.ToListAsync();
    }
    
    
    public async Task<Client> GetClientByIdAsync(string cpf)
    {
        Client client =  await _context.Clients.FirstOrDefaultAsync(x => x.Cpf == cpf);
        _context.Clients.Remove(client);

        return client;
    }

    public void ClientUpdate(string cpf, Client client)
    {
        _context.Clients.Update(client);
        _context.SaveChanges();
    }

    public async Task<Client> DeleteClientAsync(string cpf)
    {
        Client client = await _context.Clients.FirstOrDefaultAsync(x => x.Cpf == cpf);
        _context.Clients.Remove(client);
        _context.SaveChanges();
        
        return client;
    }


    
}