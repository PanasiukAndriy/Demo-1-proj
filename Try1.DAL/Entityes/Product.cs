using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Try1.DAL.Models
{
    [Table("products")]
    public partial class Product
    {
        
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("product_name")]
        [MaxLength(15)]
        public string ProductName { get; set; }

        [Required]
        [Column("price")]
        public decimal Price { get; set; }

        
        public Product(string productName, decimal price)
        {
            ProductName = productName;
            Price = price;
        }

        public Product()
        {
        }

        //public virtual ICollection<OrderProduct> OrdersProducts { get; set; }
    }
}
