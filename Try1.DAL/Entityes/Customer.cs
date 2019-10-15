using System.Collections.Generic;

namespace Try1.DAL.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public Customer(string lastName, string firstName, int phone)
        {
            LastName = lastName;
            FirstName = firstName;
            Phone = phone;
        }

        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Phone { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
