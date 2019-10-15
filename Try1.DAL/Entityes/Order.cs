using System.Collections.Generic;

namespace Try1.DAL.Models
{
    public partial class Order
    {
        public Order()
        {
            OrdersProducts = new HashSet<OrderProduct>();
        }

        public Order(int customerId)
        {
            CustomerId = customerId;
        }

        public int Id { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderProduct> OrdersProducts { get; set; }
    }
}
