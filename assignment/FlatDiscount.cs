using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class FlatDiscount : Discount
    {
        public decimal FlatAmount { get; set; }
        public FlatDiscount(string name, decimal flatAmount)
        {
            Name = name;
            FlatAmount = flatAmount;
        }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return FlatAmount * Math.Min(FlatAmount,1);
        }
    }

}
