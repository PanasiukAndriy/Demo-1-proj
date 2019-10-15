using System;
using System.Collections.Generic;
using Try1.DAL.Interfaces;
using Try1.DAL.Models;

namespace Try1.BLL
{
    static public class Shop
    {
        static public void MakeOrder(IUnitOfWork uow)
        {
            int CurrentCustomerId = Validators.GetCurrentCustomer(uow);
            Dictionary<int, int> Basket = Shop.FillBasket(uow);

            if (Basket.Count > 0)
            {
                Shop.SubmitOrder(uow, Basket, CurrentCustomerId);
            }
            Console.WriteLine("Order submited ");
        }
        static public Dictionary<int, int> FillBasket(IUnitOfWork uow)
        {
            Dictionary<int, int> Basket = new Dictionary<int, int>();
            uow.Products.ShowAllProducts();
            bool IsAdded;
            do
            {
                IsAdded = false;
                int ProductId;
                Console.WriteLine("Write the product Id to add a basket.  0  -  exit");
                if (int.TryParse(Console.ReadLine(), out ProductId) && ProductId != 0)
                {
                    if (Basket.ContainsKey(ProductId))
                        Basket[ProductId] = Basket[ProductId] + 1;
                    else
                        Basket.Add(ProductId, 1);

                    IsAdded = true;
                    Console.WriteLine("Product added to the basket");
                }
            }
            while (IsAdded);

            return Basket;
        }

        static public void SubmitOrder(IUnitOfWork uow, Dictionary<int, int> basket, int customerId)
        {
            Order MyOrder = new Order { CustomerId = customerId };
            uow.Orders.Add(MyOrder);
            uow.Complete();

            foreach (KeyValuePair<int, int> kvp in basket)
            {
                var prod = new OrderProduct { OrderId = MyOrder.Id, ProductId = kvp.Key, Quantity = kvp.Value };
                uow.OrdersProducts.Add(prod);
                uow.Complete();
            }
        }
    }
}
