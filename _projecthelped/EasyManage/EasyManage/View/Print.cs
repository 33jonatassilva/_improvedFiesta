namespace EasyManage.View;

public static class Print
{

    public static void InitialMenuOptions()
    {
        Console.WriteLine("1. Sales Management");
        Console.WriteLine("2. Admin Menu");
        Console.Write("Chose an option: ");
    }

    public static void AdminMenuOptions()
    {
        Console.Write(
            $"------------------- << MENU >> -------------------\n" +
            $"1 - Employees management\n" +
            $"2 - Clients management\n" +
            $"3 - Products management\n" +
            $"Chose an option: ");
    }

    public static void  MenuEmployeesOption()
    {
        Console.Write(
            $"1. Add Empoyee\n" +
            $"2. Edit Employee\n" +
            $"3. Delete Empoyee\n" +
            $"4. Employee Metrics\n" +
            $"Chose an option: ");
            
    }

    public static void MenuEmployeeUpdateOptions()
    {
        Console.Write(
            $"1. Edit Name\n" +
            $"2. Edit LastName\n" +
            $"3. Edit BirthDate\n" +
            $"4. Edit Client Budget Rate\n" +
            $"5. Edit All\n" +
        
            $"Select an option: ");
    }

    public static void MenuClientsOption()
    {
        Console.Write(
            $"\n1. Add Client\n" +
            $"2. List All Client\n" +
            $"3. List Client By Id\n" +
            $"4. Edit Client\n" +
            $"5. Delete Client\n" +
            $"Select an option: "
        );
    }

    public static void MenuClientUpdateOptions()
    {
        Console.Write(
        $"1. Edit Name\n" +
        $"2. Edit LastName\n" +
        $"3. Edit BirthDate\n" +
        $"4. Edit Client Budget Rate\n" +
        $"5. Edit All\n" +
        
        $"Select an option: ");
    }

    public static void MenuProductsOption()
    {
        Console.WriteLine(
            $"Add Product\n" +
            $"Edit Product\n" +
            $"Delete Product\n" +
            $"Employee Metrics");
    }
    
    
    
                                        
                                        
}