using EasyManage.Data;
using EasyManage.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyManage.Repositories;

public class ClientRepository : IClientRepository
{
    private readonly AppDbContext _context;

    public ClientRepository(AppDbContext context)
        => _context = context;
    

    public void AddClient(Client client)
    {
        _context.Clients.Add(client);
        _context.SaveChanges();
    }
    
    
    public List<Client> GetAllClients()
    {
        return _context.Clients.ToList();
    }
    
    
    public Client GetClientById(string cpf)
    {
        var client =  _context.Clients.FirstOrDefault(x => x.Cpf == cpf);
        _context.Clients.Remove(client);

        return client;
    }

    public void ClientUpdate(string cpf, Client client)
    {
        _context.Clients.Update(client);
        _context.SaveChanges();
    }

    public void DeleteClient(string cpf)
    {
        var client = _context.Clients.FirstOrDefault(x => x.Cpf == cpf);
        _context.Clients.Remove(client);
        _context.SaveChanges();
    }


    
}