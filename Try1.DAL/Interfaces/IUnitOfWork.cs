using System;

namespace Try1.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICustomerRepository Customers { get; }
        IOrderProductRepository OrdersProducts { get; }
        IOrderRepository Orders { get; }
        IProductRepository Products { get; }
                             
        void Complete();
    }
}
