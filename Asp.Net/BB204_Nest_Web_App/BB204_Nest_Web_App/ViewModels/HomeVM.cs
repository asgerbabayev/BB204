using BB204_Nest_Web_App.Models;

namespace BB204_Nest_Web_App.ViewModels;

public class HomeVM
{
    public List<Slider> Sliders { get; set; }
    public List<Category> Categories { get; set; }
    public List<Product> Products { get; set; }
}
