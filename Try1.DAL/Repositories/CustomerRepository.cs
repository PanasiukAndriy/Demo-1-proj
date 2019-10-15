using System;
using Try1.DAL.Interfaces;
using Try1.DAL.Models;



namespace Try1.DAL.Repositories
{
    class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(DemoDbContext context) : base(context)
        {
            Context = context;
        }

        public DemoDbContext Context { get; }
        

        public void AddCustomer()
        {            
            Console.WriteLine("enter last name:");
            string LastName = Console.ReadLine();            
            Console.WriteLine("enter first name:");
            string FirstName = Console.ReadLine();
            Console.WriteLine("enter phone:");
            int Phone = int.Parse(Console.ReadLine());

            Context.Customers.Add(new Customer(LastName, FirstName, Phone));            
            Context.SaveChanges();
            Console.WriteLine("Customer is added");
        }

        public bool IfExist(int CustomerId)
        {
            bool result = false;

            Customer CurrentCustomer = Context.Customers.Find(CustomerId);
            if (CurrentCustomer == null)
                result = true;
            else
            {
                result = true;
            }
            return result;
        }

        public void ShowAllCostomers()
        {
            Console.WriteLine("List all customers:");            
            foreach (Customer customer in Context.Customers)
            {
                Console.WriteLine($"Id : {customer.Id}, last name: { customer.LastName}, first name: { customer.FirstName }");
            }
        }

        public void UpdateCustomerPhone(int CustomerId, int phone)
        {
            Context.Customers.Find(CustomerId).Phone = phone;
            Context.SaveChanges();
        }
    }
}
