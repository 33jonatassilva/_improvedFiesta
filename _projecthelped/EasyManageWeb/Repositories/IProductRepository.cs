using EasyManageWeb.Models;

namespace EasyManageWeb.Repositories;

public interface IProductRepository
{
    public void Add(Product product);
    public void Update(Product product);
    public void Delete(Product product);
    public List<Product> GetAll();
    public Product GetById(Guid id);
}