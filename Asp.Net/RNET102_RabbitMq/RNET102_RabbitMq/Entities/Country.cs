using RNET102_RabbitMq.Entites;
using RNET102_RabbitMq.Entities.Base;

namespace RNET102_RabbitMq.Entities;

class Country : BaseEntity
{
    public string Name { get; set; }
    public ICollection<SaleTransaction> SaleTransactions { get; set; }
}
