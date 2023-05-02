using RNET102_RabbitMq.Entities.Base;

namespace RNET102_RabbitMq.Entites;

class Segment : BaseEntity
{
    public string Name { get; set; } = null!;
    public ICollection<SaleTransaction> SaleTransactions { get; set; }
}
