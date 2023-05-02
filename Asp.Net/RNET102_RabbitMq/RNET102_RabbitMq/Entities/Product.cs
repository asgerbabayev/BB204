using RNET102_RabbitMq.Entities.Base;

namespace RNET102_RabbitMq.Entites;

class Product : BaseEntity
{
    public ICollection<SaleTransaction> SaleTransactions { get; set; }
    public ICollection<Price> Prices { get; set; }
}
