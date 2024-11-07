using EasyManage.Models;

namespace EasyManage.Repositories.Interfaces;

public interface IProductRepository
{
    public List<Product> GetAllProducts();
    public Product GetProductById(Guid id);
    public void AddProduct(Product product);
    public void EditProduct(Product product);
    public void DeleteProduct(Product product);

}