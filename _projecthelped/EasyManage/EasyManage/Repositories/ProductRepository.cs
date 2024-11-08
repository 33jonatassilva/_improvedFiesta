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


    public Product GetProductById(Guid productId)
    {
        return _context.Products.FirstOrDefault(p => p.Id == productId);
    }

    
    public void AddProduct(Product product)
    {
        _context.Products.Add(product);
        _context.SaveChanges();
    }



    public void UpdateProduct(Product product)
    {
        var productToUpdate = _context.Products.FirstOrDefault(p => p.Id == product.Id);
        
        productToUpdate.Name = product.Name;
        productToUpdate.Price = product.Price;
        productToUpdate.Description = product.Description;
        
        _context.Products.Update(productToUpdate);
        _context.SaveChanges();

        //Console.WriteLine(product.ToString());
    }

    public void DeleteProduct(Guid productId)
    {
        var productToDelete = _context.Products.FirstOrDefault(p => p.Id == productId);
        _context.Products.Remove(productToDelete);
        _context.SaveChanges();
    }
}