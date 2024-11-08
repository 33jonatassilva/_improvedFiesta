using System.Globalization;
using EasyManage.Enums;
using EasyManage.Models;

namespace EasyManage.View.MenuOptions;

public class MenuEmployeesOptionsSwitch
{

    public static Employee Update()
    {
        Print.MenuEmployeeUpdateOptions();

        var menuEmployeeSelected = Console.ReadLine();


        var employeeToUpdate = new Employee();

        switch (menuEmployeeSelected)
        {
            case "1":
                Console.Write("Type the First name: ");
                employeeToUpdate.FirstName = Console.ReadLine();
                break;
            case "2":
                Console.Write("Type the Last name: ");
                employeeToUpdate.LastName = Console.ReadLine();
                break;
            case "3":
                Console.Write("Type the Birth Date: ");
                employeeToUpdate.BirthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy",
                    CultureInfo.InvariantCulture);
                break;
            case "4":
                Console.Write("Type the Employee Level Rate: ");
                employeeToUpdate.EEmployeeLevel = (EEmployeeLevel)int.Parse(Console.ReadLine());
                break;
        }

        return employeeToUpdate;
    }
}