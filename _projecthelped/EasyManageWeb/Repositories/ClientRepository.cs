using EasyManageWeb.Context;
using EasyManageWeb.Models;
using EasyManageWeb.Repositories.Interfaces;

namespace EasyManageWeb.Repositories;



public class ClientRepository : IClientRepository
{
    private readonly AppDbContext _context;

    public ClientRepository(AppDbContext context)
    {
        _context = context;
    }


    public void Add(Client client)
    {
        _context.Clients.Add(client);
        _context.SaveChanges();
    }

    public void Update(Client client)
    {
        _context.Clients.Update(client);
        _context.SaveChanges();
    }

    public void Delete(Client client)
    {
        _context.Clients.Remove(client);
        _context.SaveChanges();
    }

    public Client GetById(string cpf)
    {
        var client = _context.Clients.FirstOrDefault(x => x.Cpf == cpf);
        return client;
    }

    public List<Client> GetAll()
    {
        var clients = _context.Clients.ToList();
        return clients;
    }
}