using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class PremiumUser : User
    {
        //Applies Applies a FlatDiscount of $100
        public override Discount GetDiscount()
        {
            return new FlatDiscount("Premium User Discount",100);
        }
      
    }
  
}
