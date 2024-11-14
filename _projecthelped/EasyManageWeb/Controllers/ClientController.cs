using EasyManageWeb.Models;
using Microsoft.AspNetCore.Mvc;
using EasyManageWeb.Repositories;

namespace EasyManageWeb.Controllers;

[ApiController]
[Route("clients")]
public class ClientController : ControllerBase
{
    private readonly IClientRepository _clientRepository;

    public ClientController(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }
    
    [HttpPost("add")]
    public IActionResult Add([FromBody] Client client)
    {
        _clientRepository.Add(client);
        return Ok(new { message = "Client added successfully" });
    }

    [HttpPost("update")]
    public IActionResult Update([FromBody] Client client)
    {
        var existingClient = _clientRepository.GetById(client.Cpf);
        if (existingClient == null)
        {
            return NotFound(new { message = "Client not found" });
        }
        
        _clientRepository.Update(client);
        return Ok(new { message = "Client updated successfully" });
    }
    
    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        var clients = _clientRepository.GetAll();
        if (clients == null || !clients.Any())
        {
            return NotFound(new { message = "No clients found" });
        }
        
        return Ok(clients);
    }
    
    [HttpGet("{cpf}")]
    public IActionResult GetById([FromRoute] string cpf)
    {
        var client = _clientRepository.GetById(cpf);
        if (client == null)
        {
            return NotFound(new { message = "Client not found" });
        }
        
        return Ok(client);
    }
}