using System.Globalization;
using EasyManage.Enums;
using EasyManage.Models;

namespace EasyManage.View.MenuOptions;

public static class MenuClientsOptionsSwitch
{
    public static Client Update()
    {
        Print.MenuClientUpdateOptions();

        var menuClientSelected = Console.ReadLine();

        Console.Write("\nType the CPF you want to update: ");
        var cpf = Console.ReadLine();
        var clientToUpdate = new Client { Cpf = cpf };

        switch (menuClientSelected)
        {
            case "1":
                Console.Write("Type the First name: ");
                clientToUpdate.FirstName = Console.ReadLine();
                break;
            case "2":
                Console.Write("Type the Last name: ");
                clientToUpdate.LastName = Console.ReadLine();
                break;
            case "3":
                Console.Write("Type the Birth Date: ");
                clientToUpdate.BirthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy",
                    CultureInfo.InvariantCulture);
                break;
            case "4":
                Console.Write("Type the Client Budget Rate: ");
                clientToUpdate.EClientBudgetRate = (EClientBudgetRate)int.Parse(Console.ReadLine());
                break;
        }

        return clientToUpdate;
    }
}