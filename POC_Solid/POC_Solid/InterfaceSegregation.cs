using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_Solid
{
    /// <summary>
    /// Clients should not be forced to depend on interfaces they do not use.

    /// Example:
    ///     Splitting a large interface into smaller, specific ones.
    /// </summary>

    public class Order
    {
        public int ID { get; set; }
        public int ProductId { get; set; }
    }

    public interface IProductRepository
    {
        void AddProduct(Product product);
        Product GetProductById(int id);
    }

    public interface IOrderRepository
    {
        void AddOrder(Order order);
        Order GetOrderById(int id);
    }

    public class ProductRepository : IProductRepository
    {
        public void AddProduct(Product product)
        {
            // Add product logic
        }

        public Product GetProductById(int id)
        {
            // Get product by id logic
            return new Product();
        }
    }

    public class OrderRepository : IOrderRepository
    {
        public void AddOrder(Order order)
        {
            // Add order logic
        }

        public Order GetOrderById(int id)
        {
            // Get order by id logic
            return new Order();
        }
    }
}
