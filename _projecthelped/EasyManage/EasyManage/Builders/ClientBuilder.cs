using System.Globalization;
using EasyManage.Models;

namespace EasyManage.Builders;

public static class ClientBuilder
{
    public static Client Build()
    {
        Client client = new();
        Console.Write("Digite o primeiro nome do cliente: ");
        client.FirstName = Console.ReadLine();
        Console.Write("Digite o último nome do cliente: ");
        client.LastName = Console.ReadLine();
        Console.Write("Digite o CPF do cliente: ");
        client.Cpf = Console.ReadLine();
        Console.Write("Digite a data de nascimento do cliente no formato DD/MM/YYYY: ");
        client.BirthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy",  CultureInfo.InvariantCulture);
        
        return client;
    }
}