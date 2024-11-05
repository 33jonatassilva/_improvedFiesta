using EasyManage.Models;

namespace EasyManage.Repositories;

public interface IClientRepository
{
    Task<Task> AddClientAsync(Client client);
    
    Task <List<Client>> GetAllClientsAsync();
    
    
    Task<Client> GetClientByIdAsync(string cpf);
    
    void ClientUpdate(string cpf, Client client);
    
    Task<Client> DeleteClientAsync(string cpf);
}