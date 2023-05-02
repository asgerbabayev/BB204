using RNET102_RabbitMq.Entities.Base;

namespace RNET102_RabbitMq.Entites;

class Price : BaseEntity
{
    public decimal SalePrice { get; set; }
    public decimal ManufacturingPrice { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; } = null!;
    public ICollection<SaleTransaction> SaleTransactions { get; set; }
}
