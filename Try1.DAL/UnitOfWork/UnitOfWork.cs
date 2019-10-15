using Microsoft.EntityFrameworkCore;
using Try1.DAL.Interfaces;
using Try1.DAL.Models;
using Try1.DAL.Repositories;

namespace Try1.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DemoDbContext _context;
        public IOrderRepository Orders { get; private set; }
        public ICustomerRepository Customers { get; private set; }
        public IOrderProductRepository OrdersProducts { get; private set; }
        public IProductRepository Products { get; private set; }

        public UnitOfWork(DemoDbContext context)
        {
            _context = context;
            Orders = new OrderRepository(_context);
            Customers = new CustomerRepository(_context);
            OrdersProducts = new OrderProductRepository(_context);
            Products = new ProductRepository(_context);

        }

        public void Complete()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
