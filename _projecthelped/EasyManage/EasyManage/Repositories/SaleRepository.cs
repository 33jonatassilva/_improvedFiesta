using EasyManage.Data;
using EasyManage.Models;
using EasyManage.Repositories.Interfaces;

namespace EasyManage.Repositories;

public class SaleRepository : ISaleRepository
{

    private readonly AppDbContext _context;

    public SaleRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public void AddSale(Sale sale)
    {
        _context.Add(sale);
        _context.SaveChanges();
    }
}