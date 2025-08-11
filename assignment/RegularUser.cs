using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class RegularUser : User
    {

        //Applies a PercentageDiscount of 5%
        public override Discount GetDiscount()
        {
            return new PercentageDiscount("Regular User Discount", 5);
        }
    }
}
