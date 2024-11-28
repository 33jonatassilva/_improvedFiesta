using EasyManageWeb.Models;
using EasyManageWeb.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace EasyManageWeb.Controllers;




[ApiController]
[Route("sale")]
public class SaleController : ControllerBase
{


    private readonly ISaleRepository _saleRepository;

    public SaleController(ISaleRepository saleRepository) 
    {
        _saleRepository = saleRepository;
    }
    
    
    [HttpPost("new")]
    public IActionResult CreateSale(
        [FromBody] Sale sale)
    {
        _saleRepository.AddSale(sale);
        return Ok();
    }
    
    
    
    
    
     
}