using SecNine.Exercises.Enums;
using System.Text;

namespace SecNine.Exercises.Entities
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem> { };

        public Order()
        {
            
        }
        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }
        public void AddItem (OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem (OrderItem item)
        {
            Items.Remove(item);
        }
        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Order moment: {Moment.ToString("dd/MM/yyyy")}\n" +
                $"Order status {Status}\n" +
                $"Client: {Client}\n" +
                $"Order Items:");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine($"Total price: ${Total().ToString("F2")}");

            return sb.ToString();
        }
    }
}
