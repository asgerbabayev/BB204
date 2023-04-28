namespace BB204_Nest_Web_App.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public decimal SellPrice { get; set; }
    public decimal Rating { get; set; }
    public decimal CostPrice { get; set; }
    public double? Discount { get; set; }
    public int StockCount { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public bool IsDeleted { get; set; }
    public ICollection<ProductImage> ProductImages { get; set; }

}
