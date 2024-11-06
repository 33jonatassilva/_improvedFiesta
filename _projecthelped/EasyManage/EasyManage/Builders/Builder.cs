using System.Globalization;
using EasyManage.Enums;
using EasyManage.Models;

namespace EasyManage.Builders;

public class Builder
{
    public static Client Client(){
        Client client = new();
        try
        {
            Console.Write("Digite o primeiro nome do cliente: ");
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
            employee.FirstName = Console.ReadLine();
            employee.LastName = Console.ReadLine();
            employee.Cpf = Console.ReadLine();
            employee.BirthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            employee.Salary = double.Parse(Console.ReadLine());
            employee.EEmployeeLevel = (EEmployeeLevel)int.Parse(Console.ReadLine());
            
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
        return employee;
    }
}