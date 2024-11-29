using EasyManageWeb.Models;

namespace EasyManageWeb.Repositories.Interfaces;

public interface IClientRepository
{
    
    public void Add(Client client);
    public void Update(Client client);
    public void Delete(Client client);
    public Client GetById(string cpf);
    public List<Client> GetAll();

}