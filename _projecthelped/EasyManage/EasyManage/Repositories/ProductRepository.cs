using EasyManage.Data;
using EasyManage.Models;
using EasyManage.Repositories.Interfaces;

namespace EasyManage.Repositories;

public class ProductRepository : IProductRepository
{

    private readonly AppDbContext _context;

    public ProductRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public List<Product> GetAllProducts()
    {
        return _context.Products.ToList();
    }


    public Product GetProductById(Guid id)
    {
        return _context.Products.FirstOrDefault(p => p.Id == id);
    }

    
    public void AddProduct(Product product)
    {
        _context.Products.Add(product);
        _context.SaveChanges();
    }



    public void EditProduct(Product product)
    {
        _context.Products.Update(product);
        _context.SaveChanges();

        Console.WriteLine(product.ToString());
    }

    public void DeleteProduct(Product product)
    {
        _context.Products.Remove(product);
        _context.SaveChanges();
    }
}