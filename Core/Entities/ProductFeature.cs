namespace Core.Entities;

public class ProductFeature
{
    public string Id { get; set; }
    public string Color { get; set; }
    public int Height { get; set; }
    public int Width { get; set; }

    public string ProductId { get; set; }
    public Product Product { get; set; }
}