using EasyManage.Models;
using EasyManage.Repositories.Interfaces;
using EasyManage.Services.Interfaces;

namespace EasyManage.Services;

public class ProductService : IProductService
{

    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public List<Product> GetAllProducts()
    {
       return _productRepository.GetAllProducts();
    }

    public Product GetProductById(Guid id)
    {
        return _productRepository.GetProductById(id);
    }
    

    public void AddProduct(Product product)
    {
        _productRepository.AddProduct(product);
    }

    public void EditProduct(Product product)
    {
        var _product = _productRepository.GetProductById(product.Id);
        _product.Name = product.Name;
        _product.Price = product.Price;
        _product.Description = product.Description;
        
        _productRepository.EditProduct(_product);
    }
    
}