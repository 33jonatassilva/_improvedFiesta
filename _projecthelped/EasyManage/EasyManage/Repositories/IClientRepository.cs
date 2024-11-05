using EasyManage.Models;

namespace EasyManage.Repositories;

public interface IClientRepository
{
    void AddClient(Client client);
    List<Client> GetAllClients();
    Client GetClientById(string cpf);
    void ClientUpdate(string cpf, Client client);
    void DeleteClient(string cpf);
}