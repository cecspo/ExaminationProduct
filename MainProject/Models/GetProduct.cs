namespace MainProject.Models;

public class GetProduct
{
    public string Id { get; set; } = Guid.NewGuid().ToString();

    public string ProductName { get; set; } = null!;

    public string Price { get; set; } = null!;
}
