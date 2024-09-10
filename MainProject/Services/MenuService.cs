using MainProject.Models;

namespace MainProject.Services;

public static class MenuService
{        
    private static void AddProductMenu()
    {
        List<GetProduct> products = [];

        var product = new GetProduct();
        
        Console.Clear();
        Console.WriteLine("-- ADD PRODUCT --");

        Console.WriteLine("Please write your products name: ");
        product.ProductName = Console.ReadLine() ?? "";

        Console.WriteLine("Please enter the price of the product");
        product.Price = Console.ReadLine() ?? "";

        product.Add(Console.ReadLine());
    }

    private static string ListProductMenu()
    {
        Console.WriteLine("-- LIST OF PRODUCTS --");
        try
        {
            foreach (var product in GetProduct)
                Console.WriteLine($"Product name: {product.ProductName} \n Product price: {product.Price} \n Product ID: {product.Id}");
        }
        catch
        { 

        }
        return;
    }

    private static void ExitChoiceMenu()
    {
        Console.Write("Are you sure you want to exit? (y/n) ");
        var answer = Console.ReadLine() == "n";
        if (!answer) 
            Environment.Exit(0);
    }

    public static void MenuChoiceMenu()
    {
        Console.Clear();
        Console.WriteLine("-- WELCOME --");

        Console.WriteLine("1. Add a product");
        Console.WriteLine("2. List all products");
        Console.WriteLine("0. Exit program");

        Console.Write("Enter your choice: ");

        if (int.TryParse(Console.ReadLine(), out int choice))
        {
            switch (choice)
            {
                case 1:
                    AddProductMenu();
                    Console.ReadLine();
                    break;
                    
                case 2:
                    Console.ReadLine();
                    break;

                case 0:
                    ExitChoiceMenu();
                    break;

                default:
                    Console.WriteLine("You have choicen a invalid option. Choice again.");
                    Console.ReadLine();
                    break;
            }
        }
    }


}
