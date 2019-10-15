using System.Collections.Generic;
using Try1.DAL.Models;

namespace Try1.DAL.Interfaces
{
    public interface IOrderRepository : IRepository<Order>
    {
        IEnumerable<Order> ShowAllOrders();
        
    }
}
