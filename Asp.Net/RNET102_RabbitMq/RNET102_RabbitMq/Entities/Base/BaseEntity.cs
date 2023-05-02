namespace RNET102_RabbitMq.Entities.Base;

class BaseEntity<TKey>
{
    public TKey Id { get; set; } = default!;
}

class BaseEntity : BaseEntity<int> { }
