namespace File__Json__Xml_Writer___Reader.Models;

internal class OrderItem
{
    public int Id { get; set; }
    public Product Product { get; set; }
    public double TotalPrice { get; set; }
    public int Count { get; set; }
}
