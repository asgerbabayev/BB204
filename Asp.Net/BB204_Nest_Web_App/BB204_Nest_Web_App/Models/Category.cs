using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BB204_Nest_Web_App.Models;

public class Category
{
    public int Id { get; set; }
    //[Required]
    [MaxLength(100), MinLength(2)]
    public string Name { get; set; }
    public string Logo { get; set; }
    public string? Photo { get; set; }
    [NotMapped]
    public IFormFile PhotoFile { get; set; }
    public bool IsDeleted { get; set; }
    public ICollection<Product>? Products { get; set; }

}
