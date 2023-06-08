namespace JwtExample.DTO_s.ProductDto_s;

public class ProductGetDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public double Price { get; set; }
    public int Count { get; set; }
}
