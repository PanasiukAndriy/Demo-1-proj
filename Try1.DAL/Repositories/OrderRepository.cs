using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Try1.DAL.Interfaces;
using Try1.DAL.Models;

namespace Try1.DAL.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(DemoDbContext context) : base(context)
        {
        }

        public IEnumerable<Order> ShowAllOrders()
        {
            throw new NotImplementedException();
        }
    }
}
