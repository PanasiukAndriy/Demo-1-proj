using Try1.DAL.Models;

namespace Try1.DAL.Interfaces
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        void AddCustomer();

        public void ShowAllCostomers();
        
        void UpdateCustomerPhone(int CustomerId, int phone);

        bool IfExist(int CustomerId);
        
    }
}
