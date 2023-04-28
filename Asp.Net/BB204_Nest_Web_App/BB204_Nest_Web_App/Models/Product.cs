namespace BB204_Nest_Web_App.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
    public double Rating { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public bool IsDeleted { get; set; }
    public ICollection<ProductImage> ProductImages { get; set; }

}
