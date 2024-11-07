using EasyManage.Models;

namespace EasyManage.Repositories.Interfaces;

public interface IClientRepository
{
    void AddClient(Client client);
    List<Client> GetAllClients();
    Client GetClientById(string cpf);
    void ClientUpdate(Client client);
    void DeleteClient(string cpf);
}