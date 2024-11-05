namespace EasyManage.View;

public static class Print
{

    public static void MenuOptionInitial()
    {
        Console.Write(
            $"------------------- << MENU >> -------------------\n" +
            $"1 - Employees management\n" +
            $"2 - Clients management\n" +
            $"3 - Products management\n" +
            $"Escolha a opcao desejada: ");
    }

    public static void  MenuEmployeesOption()
    {
        Console.WriteLine(
            $"Add Empoyee\n" +
            $"Edit Employee\n" +
            $"Delete Empoyee\n" +
            $"Employee Metrics");
    }

    public static void MenuClientsOption()
    {
        Console.WriteLine(
            $"Add Empoyee\n" +
            $"Edit Employee\n" +
            $"Delete Empoyee\n" +
            $"Employee Metrics"
        );
    }

    public static void MenuProductsOption()
    {
        Console.WriteLine(
            $"Add Empoyee\n" +
            $"Edit Employee\n" +
            $"Delete Empoyee\n" +
            $"Employee Metrics");
    }
                                        
                                        
}