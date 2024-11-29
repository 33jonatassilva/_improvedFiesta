using EasyManageWeb.Context;
using EasyManageWeb.Models;
using EasyManageWeb.Repositories.Interfaces;

namespace EasyManageWeb.Repositories;

public class SaleRepository : ISaleRepository
{

    private readonly AppDbContext _context;

    public SaleRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public void AddSale(Sale sale)
    {
        _context.Sales.Add(sale);
        _context.SaveChanges();
    }
}