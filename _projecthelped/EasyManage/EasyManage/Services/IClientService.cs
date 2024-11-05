using EasyManage.Models;

namespace EasyManage.Services;

public interface IClientService
{
    Task AddClientAsync(Client client);
    Task<List<Client>> GetAllClientsAsync();
    Task<Client> GetClientByIdAsync(string id);
    void ClientUpdate(string cpf, Client clientUpdate);
    Task<Client> DeleteClientByIdAsync(string cpf);
}