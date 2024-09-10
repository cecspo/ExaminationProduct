namespace MainProject.Services;

public static class MenuService
{
    private 

    private static void MenuChoiceMenu()
    {
        Console.Clear();
        Console.WriteLine("-- WELCOME --");

        Console.Write("1. Add a product");
        Console.Write("2. List all products");
        Console.Write("0. Exit program");
        Console.Write("Enter your choice: ");
        
        var choice = Console.ReadLine() ?? "";

        if (int.TryParse(Console.ReadLine), out in choice))
        {
            switch (choice)
            {
                case "1":
                    Console.ReadLine();
                    break;
                    
                case "2":
                    Console.ReadLine();
                    break;

                case "0":
                    break;
            }
        }
    }


}
