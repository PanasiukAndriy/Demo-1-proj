using System;
using Microsoft.EntityFrameworkCore;
using Try1.DAL.Interfaces;
using Try1.DAL.Models;

namespace Try1.DAL.Repositories
{
    class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(DemoDbContext context) : base(context)
        {
        }

        public void AddNewProduct()
        {
            Console.WriteLine("enter product name:");
            string ProductName = Console.ReadLine();
            Console.WriteLine("enter price:");
            decimal Price;
            while (!decimal.TryParse(Console.ReadLine(), out Price))
            {
                Console.WriteLine("price incorrect, repeat..");
            }
            Context.Products.Add(new Product(ProductName, Price));            
            Context.SaveChanges();
            Console.WriteLine("Product is added");
        }

        public void RemoveProduct()
        {
            throw new NotImplementedException();
        }

        public void ShowAllProducts()
        {
            Console.WriteLine("List all products:");
            foreach (Product product in Context.Products)
            {
                Console.WriteLine($"Id : {product.Id}  product: { product.ProductName}, price: { product.Price }");
            }
        }
    }
}
