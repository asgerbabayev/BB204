using JwtExample.Data.Entities.Common;
namespace JwtExample.Data.Entities;

public class Product : BaseAuditableEntity
{
    public string Name { get; set; } = null!;
    public double Price { get; set; }
    public int Count { get; set; }
}