namespace Shared.Method;
using Shared.Classes;

public class GetProduct
{
    List<Product> productInfo = []; 

    public void AddProduct()
    { 
        do
            {
                Console.Clear();
                Product products = new();

                Console.Write("Skriv namnet på din produkt: ");
                products.Name = Console.ReadLine();

                Console.Write("Skriv priset på din produkt: ");
                products.Price = decimal.Parse(Console.ReadLine()!);

                productInfo.Add(products);

            Console.Write("Vill du addera ytterligare en produkt? (y/n) ");
            var answer = Console.ReadLine();
                
                if ((answer != "y") && (answer != "n"))
                {
                    Console.Write("Du har angivet ett fel värde. Försök igen! (y/n) ");
                    break;
                }
                
                else if (answer.ToString() == "y")
                {
                    AddProduct();
                }
                
                else
                {
                     Console.Write("Tack för din tid. Nedan ser du listan över produkter:");
                    ProductList();
                }

        }

        while (true);

    }

    public void ProductList()   
    {
        foreach (Product product in productInfo)
        Console.WriteLine($"Produktens namn: {product.Name} \n Produktens pris: {product.Price}:- \n Produktens personliga ID: {product.Id}");
    }


}
