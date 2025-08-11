using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class BuyOneGetOneDiscount : Discount
    {
        public BuyOneGetOneDiscount(string name)
        {
            Name = name;
        }
        // Discount Amount=(Price/2)×(Quantity÷2)
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return (price/2) * (quantity / 2);
        }
    }

}
