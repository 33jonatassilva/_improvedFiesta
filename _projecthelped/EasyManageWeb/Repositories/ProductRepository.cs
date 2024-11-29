using EasyManageWeb.Context;
using EasyManageWeb.Models;
using EasyManageWeb.Repositories.Interfaces;

namespace EasyManageWeb.Repositories;

public class ProductRepository : IProductRepository
{

    private readonly AppDbContext _context;

    public ProductRepository(AppDbContext context)
    {
        _context = context;
    }
    
    
    
    public void Add(Product product)
    {
        _context.Products.Add(product);
        _context.SaveChanges();
    }

    public void Update(Product product)
    {
        throw new NotImplementedException();
    }

    public void Delete(Guid id)
    {
        var product = _context.Products.FirstOrDefault(x => x.Id == id);
        _context.Products.Remove(product);
        _context.SaveChanges();
    }

    public List<Product> GetAll()
    {
        return _context.Products.ToList();
    }

    public Product GetById(Guid id)
    {
        return _context.Products.FirstOrDefault(x => x.Id == id);
    }
}