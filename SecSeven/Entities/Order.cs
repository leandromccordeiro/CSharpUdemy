using SecSeven.Entities.Enums;

namespace SecSeven.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public override string ToString()
        {
            return $"{Id}, {Moment}, {Status}";
        }
    }
}
