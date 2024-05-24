using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_Solid
{
    /// <summary>
    /// Classes should be open for extension but closed for modification.

    /// Example:
    ///     Implementing different discount strategies without modifying the existing discount calculation logic.
    /// </summary>

    public abstract class Discount
    {
        public abstract decimal Apply(decimal price);
    }

    public class NoDiscount : Discount
    {
        public override decimal Apply(decimal price) => price;
    }

    public class PercentageDiscount : Discount
    {
        private readonly decimal _percentage;

        public PercentageDiscount(decimal percentage)
        {
            _percentage = percentage;
        }

        public override decimal Apply(decimal price)
        {
            return price - (price * _percentage / 100);
        }
    }

    public class OrderService
    {
        private readonly Discount _discount;

        public OrderService(Discount discount)
        {
            _discount = discount;
        }

        public decimal CalculateTotal(decimal price)
        {
            return _discount.Apply(price);
        }
    }
}
