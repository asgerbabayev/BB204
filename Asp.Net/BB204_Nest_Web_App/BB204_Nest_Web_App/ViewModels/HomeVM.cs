using BB204_Nest_Web_App.Models;

namespace BB204_Nest_Web_App.ViewModels;

public class HomeVM
{
    public List<Slider> Sliders { get; set; }
    public List<Category> PopularCategories { get; set; }
    public List<Category> RandomCategories { get; set; }
    public List<Product> TopRatedProducts { get; set; }
    public List<Product> RecentProducts { get; set; }
    public List<Product> Products { get; set; }
}
