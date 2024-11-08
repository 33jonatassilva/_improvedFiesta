using System.Globalization;
using EasyManage.Enums;
using EasyManage.Models;
using EasyManage.Repositories.Interfaces;

namespace EasyManage.Builders;

public class Builder
{

    private readonly IProductRepository _productRepository;

    public Builder(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    
    
    public static Client Client(){
        Client client = new();
        try
        {
            Console.Write("\nDigite o primeiro nome do cliente: ");
            client.FirstName = Console.ReadLine();
            Console.Write("Digite o último nome do cliente: ");
            client.LastName = Console.ReadLine();
            Console.Write("Digite o CPF do cliente: ");
            client.Cpf = Console.ReadLine();
            Console.Write("Digite a data de nascimento do cliente no formato DD/MM/YYYY: ");
            client.BirthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
        return client;
    }

    public static Employee Employee()
    {
        Employee employee = new();
        
        try
        {
            Console.Write("\nDigite o primeiro nome do funcionário: ");
            employee.FirstName = Console.ReadLine();
            Console.Write("Digite o último nome do funcionario: ");
            employee.LastName = Console.ReadLine();
            Console.Write("Digite o CPF do funcionario: ");
            employee.Cpf = Console.ReadLine();
            Console.Write("Digite a data de nascimento do funcionario no formato DD/MM/YYYY: ");
            employee.BirthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Digite o salário do funcionario: ");
            employee.Salary = double.Parse(Console.ReadLine());
            Console.Write("Digite o Level do funcionario: ");
            employee.EEmployeeLevel = (EEmployeeLevel)int.Parse(Console.ReadLine());
            
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
        return employee;
    }


    public static Product Product()
    {
        
        Product product = new();
        Console.Write("\nDigite o nome do produto: ");
        product.Name = Console.ReadLine();
        Console.Write("\nDigite o preço do produto: ");
        product.Price = double.Parse(Console.ReadLine());
        Console.Write("Adicione uma descrição ao produto: ");
        product.Description = Console.ReadLine();

        return product;


    }

    public static Sale Sale()
    {
        Console.WriteLine("Digite o Id do funcionário: ");
        var employeeId = Console.ReadLine();
        Console.WriteLine("Digite o Id do Cliente: ");
        var clientId = Console.ReadLine();
        var items = new List<SaleItems>();
        var item = new SaleItems();
        var insertMoreItems = true;
        var continuer = "";
        
        
        var sale = new Sale
        {
            EmployeeId = employeeId,
            ClientId = clientId
        };
        
        while (insertMoreItems)
        {
            
            item.SaleId = sale.Id;
            Console.Write("Digite o Id do produto: ");
            item.ProductId = Guid.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade do produto: ");
            item.Quantity = int.Parse(Console.ReadLine());
            
            items.Add(item);
            while (continuer != "N" && continuer != "S")
            {
                Console.Write("Deseja inserir mais itens do cliente? (s/n): ");
                continuer = Console.ReadLine().ToUpper();
            }

            if (continuer == "N") insertMoreItems = false;
               
        }
        
        sale.SaleItems = items;

        return sale;

    }
}