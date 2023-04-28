namespace BB204_Nest_Web_App.Models;

public class ProductImage
{
    public int Id { get; set; }
    public string Image { get; set; }
    public bool IsFront { get; set; }
    public bool IsBack { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
}
