using EasyManage.Models;

namespace EasyManage.Services.Interfaces;

public interface IProductService
{
    List<Product> GetAllProducts();

    Product GetProductById(Guid id);

    void AddProduct(Product product);

    void EditProduct(Product product);
}