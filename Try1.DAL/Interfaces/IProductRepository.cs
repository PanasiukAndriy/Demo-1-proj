using Try1.DAL.Models;

namespace Try1.DAL.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        void AddNewProduct();
        void RemoveProduct();

        void ShowAllProducts();
        

    }
}
