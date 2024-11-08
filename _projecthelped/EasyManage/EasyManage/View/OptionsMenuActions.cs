using System.Globalization;
using EasyManage.Builders;
using EasyManage.Enums;
using EasyManage.Repositories.Interfaces;
using EasyManage.Services;
using EasyManage.Services.Interfaces;
using EasyManage.View.MenuOptions;

namespace EasyManage.View;


public class OptionsMenuActions : IOptionsMenuActions
{



    private readonly IClientService _clientService;
    private readonly IEmployeeService _employeeService;
    private readonly IProductService _productService;
    private readonly ISaleService _saleService;
    
    

    public OptionsMenuActions
    (
    IClientService clientService,
    IEmployeeService employeeService,
    IProductService productService,
    ISaleService saleService
    )
    {
        _clientService = clientService;
        _employeeService = employeeService;
        _productService = productService;
        _saleService = saleService;
    }

   
    public void OptionsInitialMenu()
    {

        Print.AdminMenuOptions();
        var optionSelected = Console.ReadLine();
        
        if (optionSelected == "1")
        {
            Print.MenuEmployeesOption();
            var optionMenuEmployeeSelected = Console.ReadLine();

            switch (optionMenuEmployeeSelected)
            {
                case "1":

                    _employeeService.AddEmployee(Builder.Employee());
                    break;

                case "2":

                    var employees = _employeeService.GetAllEmployees();

                    foreach (var item in employees)
                        Console.WriteLine(item.ToString());

                    break;

                case "3":
                
                    Console.Write("\n\nType the CPF you want: ");
                    var employee = _employeeService.GetEmployeeById(Console.ReadLine());
                    Console.WriteLine(employee.ToString());
                    break;

                case "4":

                    Console.Write("\nType the CPF you want to update: ");
                    var cpf = Console.ReadLine();
                    _employeeService.EmployeeUpdate(cpf, MenuEmployeesOptionsSwitch.Update());
                    
                    
                    return;

                case "5":
                    _employeeService.DeleteEmployeeById(Console.ReadLine());
                    break;

            }
            return;
        }

        if (optionSelected == "2")
        {

            Print.MenuClientsOption();
            var optionMenuClientSelected = Console.ReadLine();

            switch (optionMenuClientSelected)
            {
                case "1":

                    _clientService.AddClient(Builder.Client());
                    break;

                case "2":

                    var clients = _clientService.GetAllClients();

                    foreach (var item in clients)
                        Console.WriteLine(item.ToString());

                    break;

                case "3":

                    var client = _clientService.GetClientById(Console.ReadLine());
                    break;

                case "4":
                    
                    _clientService.ClientUpdate(MenuClientsOptionsSwitch.Update());
                    return;

                case "5":
                    _clientService.DeleteClientById(Console.ReadLine());
                    break;

            }
            return;
        }

        if (optionSelected == "3")
        {
            Print.MenuProductsOption();

            var optionMenuProductSelected = Console.ReadLine();

            switch (optionMenuProductSelected)
            {
                case "1":

                    _productService.AddProduct(Builder.Product());
                    return;

                case "2":

                    var products = _productService.GetAllProducts();
                    foreach (var product in products)
                        Console.WriteLine(product.ToString());
                    return;

                case "3":

                    var client = _productService.GetProductById(Guid.Parse(Console.ReadLine()));
                    Console.WriteLine(client.ToString());
                    return;

                case "4":
                    
                    _productService.UpdateProduct(MenuProductsOptionsSwitch.Update());
                    break;

                case "5":
                
                    _productService.DeleteProduct(Guid.Parse(Console.ReadLine()));
                    return;

            }
        }
    }
    
    
    public void InitialMenuSales()
    {
    }
}
