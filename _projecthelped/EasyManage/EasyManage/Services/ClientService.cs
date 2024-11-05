
using EasyManage.Models;
using EasyManage.Repositories;


namespace EasyManage.Services;
    
    // Tratamento de regras de negócio
    
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        
        public ClientService(IClientRepository clientRepository) 
            => _clientRepository = clientRepository;
    
        public async Task AddClientAsync(Client client)
            => await _clientRepository.AddClientAsync(client);
    
        public async Task<List<Client>> GetAllClientsAsync()
           => await _clientRepository.GetAllClientsAsync();
        
        public async Task<Client> GetClientByIdAsync(string cpf)
            => await _clientRepository.GetClientByIdAsync(cpf);
        
        public void ClientUpdate(string cpf, Client clientUpdate)
            => _clientRepository.ClientUpdate(cpf, clientUpdate);

        public async Task<Client> DeleteClientByIdAsync(string cpf)
            => await _clientRepository.DeleteClientAsync(cpf);
    
    
}