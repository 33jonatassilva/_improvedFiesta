using EasyManage.Models;

namespace EasyManage.View.MenuOptions;

public static class MenuProductsOptionsSwitch
{

    public static Product Update () 
    { 
    
        Print.MenuProductsUpdateOptions();
        
        
        var menuProductSelected = Console.ReadLine();
        var productToUpdate = new Product();

        switch (menuProductSelected)
        {

            case "1":
            Console.Write("Type the name of the product: ");
            productToUpdate.Name = Console.ReadLine();
            break;
            case "2":
            Console.Write("Type the price: ");
            productToUpdate.Price = double.Parse(Console.ReadLine());
            break;
            case "3":
            Console.Write("Type the description: ");
            productToUpdate.Description = Console.ReadLine();
            break;
            case "4":
            Console.Write("Type the name of the product: ");
            productToUpdate.Name = Console.ReadLine();
            Console.Write("Type the price: ");
            productToUpdate.Price = double.Parse(Console.ReadLine());
            Console.Write("Type the description: ");
            productToUpdate.Description = Console.ReadLine();
            break;
        }

        return productToUpdate;
        
    }
}