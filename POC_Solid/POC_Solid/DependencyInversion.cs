using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace POC_Solid
{
    /// <summary>
    /// High-level modules should not depend on low-level modules. Both should depend on abstractions.

    /// Example:
    ///     Using interfaces to depend on abstractions instead of concrete classes.
    /// </summary>

    public interface IDiscount
    {
        decimal Apply(decimal price);
    }

    public class PercentDiscount : IDiscount
    {
        private readonly decimal _percentage;

        public PercentDiscount(decimal percentage)
        {
            _percentage = percentage;
        }

        public decimal Apply(decimal price)
        {
            return price - (price * _percentage / 100);
        }
    }

    public class OrdersService
    {
        private readonly IDiscount _discount;

        public OrdersService(IDiscount discount)
        {
            _discount = discount;
        }

        public decimal CalculateTotal(decimal price)
        {
            return _discount.Apply(price);
        }
    }

}
