namespace BB204_Nest_Web_App.Models;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Logo { get; set; }
    public string Photo { get; set; }
    public bool IsDeleted { get; set; }
    public ICollection<Product> Products { get; set; }

}
