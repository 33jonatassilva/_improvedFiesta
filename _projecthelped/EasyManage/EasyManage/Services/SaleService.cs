using EasyManage.Models;
using EasyManage.Repositories.Interfaces;
using EasyManage.Services.Interfaces;

namespace EasyManage.Services;

public class SaleService : ISaleService
{

    private readonly ISaleRepository _saleRepository;
    private readonly IProductRepository _productRepository;

    public SaleService(ISaleRepository saleRepository, IProductRepository productRepository)
    {
        _saleRepository = saleRepository;
        _productRepository = productRepository;
    }

    public void AddSale(Sale sale)
    {
        foreach (var item in sale.SaleItems)
        {
            item.TotalValue =  _productRepository.GetProductById(item.ProductId).Price * item.Quantity;
        }
        _saleRepository.AddSale(sale);
    }

public void AddSale(string clientId, string employeeId, List<SaleItems> saleItems)
{
    var sale = new Sale
    {
        ClientId = clientId,
        EmployeeId = employeeId,
        SaleItems = saleItems
    };
    _saleRepository.AddSale(sale);
}
}