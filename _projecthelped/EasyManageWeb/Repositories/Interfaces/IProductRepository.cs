using EasyManageWeb.Models;

namespace EasyManageWeb.Repositories.Interfaces;

public interface IProductRepository
{
    public void Add(Product product);
    public void Update(Product product);
    public void Delete(Guid id);
    public List<Product> GetAll();
    public Product GetById(Guid id);
}