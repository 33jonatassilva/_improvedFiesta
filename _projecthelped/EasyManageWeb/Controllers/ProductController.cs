using EasyManageWeb.Models;
using EasyManageWeb.Repositories;
using EasyManageWeb.Repositories.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace EasyManageWeb.Controllers;





[ApiController]
[Route("product")]
public class ProductController : ControllerBase
{



    private readonly IProductRepository _productRepository;

    public ProductController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    
    
    [HttpPost]
    public IActionResult Post([FromBody] Product product)
    {
        _productRepository.Add(product);
        return Ok();
    }


    [HttpPut]
    public IActionResult Update([FromBody] Product product)
    {
        _productRepository.Update(product);
        return Ok(product);
    }


    [HttpGet("get")]
    public IActionResult Get()
    {
        var products = _productRepository.GetAll();
        return Ok(products);
    }

    [HttpGet("get/{id}")]
    public IActionResult GetById(Guid id)
    {
        var product = _productRepository.GetById(id);
        return Ok(product);
    }

    [HttpDelete("delete/{id}")]
    public IActionResult Delete([FromRoute] Guid id)
    {
        _productRepository.Delete(id);
        return Ok();
    }


    
}