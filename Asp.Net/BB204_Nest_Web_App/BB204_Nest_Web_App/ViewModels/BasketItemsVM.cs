namespace BB204_Nest_Web_App.ViewModels;

public class BasketItemsVM
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public decimal SellPrice { get; set; }
    public int Count { get; set; }
    public string Image { get; set; }


}
