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

    public void UpdateProduct(Product product)
    {
        _productRepository.UpdateProduct(product);
    }
    
    public void UpdateProduct(Guid productId, Product product)
    {
        var productToUpdate = _productRepository.GetProductById(productId);
        productToUpdate.Name = product.Name;
        productToUpdate.Price = product.Price;
        productToUpdate.Description = product.Description;
        
        _productRepository.UpdateProduct(productToUpdate);
    }


    public void DeleteProduct(Guid productId)
    {
        _productRepository.DeleteProduct(productId);
    }
    
}