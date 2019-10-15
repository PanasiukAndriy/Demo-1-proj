using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Try1.BLL;
using Try1.DAL.Interfaces;
using Try1.DAL.Models;
using Try1.DAL.UnitOfWork;

namespace Try1
{
    class Program
    {
        static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                 .AddJsonFile("appConfig.json")
                 .Build();

            var serviceCollection = new ServiceCollection()
                .AddDbContext<DemoDbContext>(
                    options => options.UseSqlServer(
                        configuration.GetConnectionString("default")
                    )
                )
                .AddTransient<IUnitOfWork, UnitOfWork>();

            using var serviceProvider = serviceCollection.BuildServiceProvider();
            using var uow = serviceProvider.GetRequiredService<IUnitOfWork>();
            
            bool Alive = true;
            while (Alive)
            {
                Methods.ShowMenu();
                int variant = 0;
                int.TryParse(Console.ReadLine().ToString(), out variant);
                switch (variant)
                {
                    case 1:                        
                        uow.Customers.AddCustomer();
                        break;

                    case 2:
                        uow.Products.AddNewProduct();
                        break;

                    case 3:
                        Shop.MakeOrder(uow);
                        break;

                    case 4:
                        uow.Customers.ShowAllCostomers();
                        break;

                    default:
                        Alive = false;
                        break;
                }
            }
        }
    }
}
