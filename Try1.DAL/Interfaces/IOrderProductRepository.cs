using System;
using System.Collections.Generic;
using Try1.DAL.Models;

namespace Try1.DAL.Interfaces
{
    public interface IOrderProductRepository : IRepository<OrderProduct>
    {                
        void GetTotalOrderedProducts();        
    }
}
