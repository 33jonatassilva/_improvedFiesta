
using EasyManage.Models;
using EasyManage.Repositories;


namespace EasyManage.Services;
    
    // Tratamento de regras de negócio
    
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        
        public ClientService(IClientRepository clientRepository) 
            => _clientRepository = clientRepository;
    
        public void AddClient(Client client)
            => _clientRepository.AddClient(client);
    
        public List<Client> GetAllClients()
           => _clientRepository.GetAllClients();
        
        public Client GetClientById(string cpf)
            => _clientRepository.GetClientById(cpf);
        
        public void ClientUpdate(string cpf, Client clientUpdate)
            => _clientRepository.ClientUpdate(cpf, clientUpdate);

        public void DeleteClientById(string cpf)
            => _clientRepository.DeleteClient(cpf);
    
    
}