using EasyManage.Models;

namespace EasyManage.Repositories.Interfaces;

public interface IProductRepository
{
    public List<Product> GetAllProducts();
    public Product GetProductById(Guid productId);
    public void AddProduct(Product product);
    public void UpdateProduct(Product product);
    public void DeleteProduct(Guid productId);

}