using System.Globalization;
using EasyManage.Builders;
using EasyManage.Enums;
using EasyManage.Services;
using EasyManage.Services.Interfaces;

namespace EasyManage.View;


public class OptionsMenuActions : IOptionsMenuActions
{
    private readonly IClientService _clientService;
    private readonly IEmployeeService _employeeService;

    public OptionsMenuActions(IClientService clientService, IEmployeeService employeeService)
    {
        _clientService = clientService;
        _employeeService = employeeService;
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

                    var employee = _employeeService.GetEmployeeById(Console.ReadLine());
                    break;

                case "4":
                    Print.MenuEmployeeUpdateOptions();

                    var menuEmployeeSelected = Console.ReadLine();

                    Console.Write("\nType the CPF you want to update: ");
                    var cpf = Console.ReadLine();
                    var employeeUpdater = _employeeService.GetEmployeeById(cpf);

                    switch (menuEmployeeSelected)
                    {
                        case "1":
                            Console.Write("Type the First name: ");
                            employeeUpdater.FirstName = Console.ReadLine();
                            break;
                        case "2":
                            Console.Write("Type the Last name: ");
                            employeeUpdater.LastName = Console.ReadLine();
                            break;
                        case "3":
                            Console.Write("Type the Birth Date: ");
                            employeeUpdater.BirthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy",
                                CultureInfo.InvariantCulture);
                            break;
                        case "4":
                            Console.Write("Type the Employee Level Rate: ");
                            employeeUpdater.EEmployeeLevel = (EEmployeeLevel)int.Parse(Console.ReadLine());
                            break;
                    }

                    _employeeService.EmployeeUpdate(employeeUpdater);
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
                    Print.MenuClientUpdateOptions();

                    var menuClientSelected = Console.ReadLine();

                    Console.Write("\nType the CPF you want to update: ");
                    var cpf = Console.ReadLine();
                    var clientUpdater = _clientService.GetClientById(cpf);

                    switch (menuClientSelected)
                    {
                        case "1":
                            Console.Write("Type the First name: ");
                            clientUpdater.FirstName = Console.ReadLine();
                            break;
                        case "2":
                            Console.Write("Type the Last name: ");
                            clientUpdater.LastName = Console.ReadLine();
                            break;
                        case "3":
                            Console.Write("Type the Birth Date: ");
                            clientUpdater.BirthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy",
                                CultureInfo.InvariantCulture);
                            break;
                        case "4":
                            Console.Write("Type the Client Budget Rate: ");
                            clientUpdater.EClientBudgetRate = (EClientBudgetRate)int.Parse(Console.ReadLine());
                            break;
                    }

                    _clientService.ClientUpdate(clientUpdater);
                    return;

                case "5":
                    _clientService.DeleteClientById(Console.ReadLine());
                    break;

            }
            return;
        }

        if (optionSelected == "3")
        {
            Print.MenuClientsOption();

            var optionMenuClientSelected = Console.ReadLine();

            switch (optionMenuClientSelected)
            {
                case "1":

                    _clientService.AddClient(Builder.Client());
                    return;

                case "2":

                    var clients = _clientService.GetAllClients();

                    foreach (var item in clients)
                        Console.WriteLine(item.ToString());

                    return;

                case "3":

                    var client = _clientService.GetClientById(Console.ReadLine());
                    return;

                case "4":
                    Print.MenuClientUpdateOptions();

                    var menuClientSelected = Console.ReadLine();

                    Console.Write("\nType the CPF you want to update: ");
                    var cpf = Console.ReadLine();
                    var clientUpdater = _clientService.GetClientById(cpf);

                    switch (menuClientSelected)
                    {
                        case "1":
                            Console.Write("Type the First name: ");
                            clientUpdater.FirstName = Console.ReadLine();
                            return;
                        case "2":
                            Console.Write("Type the Last name: ");
                            clientUpdater.LastName = Console.ReadLine();
                            return;
                        case "3":
                            Console.Write("Type the Birth Date: ");
                            clientUpdater.BirthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy",
                                CultureInfo.InvariantCulture);
                            return;
                        case "4":
                            Console.Write("Type the Client Budget Rate: ");
                            clientUpdater.EClientBudgetRate = (EClientBudgetRate)int.Parse(Console.ReadLine());
                            return;
                    }

                    _clientService.ClientUpdate(clientUpdater);
                    break;

                case "5":
                    _clientService.DeleteClientById(Console.ReadLine());
                    return;

            }
        }



    }
}
