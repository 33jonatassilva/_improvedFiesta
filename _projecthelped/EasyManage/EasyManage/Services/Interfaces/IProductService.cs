using EasyManage.Models;

namespace EasyManage.Services.Interfaces;

public interface IProductService
{
    List<Product> GetAllProducts();

    Product GetProductById(Guid productId);

    void AddProduct(Product product);

    void UpdateProduct(Product product);

    //void UpdateProduct(Guid productId, Product product);
    
    void DeleteProduct(Guid productId);
}