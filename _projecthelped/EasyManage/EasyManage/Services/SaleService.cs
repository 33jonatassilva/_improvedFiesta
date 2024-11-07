using EasyManage.Models;
using EasyManage.Repositories.Interfaces;

namespace EasyManage.Services;

public class SaleService
{

    private readonly ISaleRepository _saleRepository;

    public SaleService(ISaleRepository saleRepository)
    {
        _saleRepository = saleRepository;
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