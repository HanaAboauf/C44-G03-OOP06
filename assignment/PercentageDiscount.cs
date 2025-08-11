using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class PercentageDiscount : Discount
    {
        // Discount Amount=Price×Quantity×(Percentage/100)
        public decimal Percentage { get; set; }
        public PercentageDiscount(string name, decimal percentage)
        {
            Name = name;
            Percentage = percentage;
        }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return price * (Percentage / 100) * quantity;
        }
    }

}
