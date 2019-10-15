using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Try1.DAL.Interfaces;
using Try1.DAL.Models;

namespace Try1.DAL.Repositories
{
    class OrderProductRepository : Repository<OrderProduct>, IOrderProductRepository
    {
        public OrderProductRepository(DemoDbContext context) : base(context)
        {
        }
        public void GetTotalOrderedProducts()
        {
            throw new System.NotImplementedException();
        }
    }
}
