namespace Shared.Classes;

public class Product
{
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public string? Id { get; set; } = Guid.NewGuid().ToString();
}
