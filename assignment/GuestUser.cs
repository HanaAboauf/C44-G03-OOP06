using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class GuestUser : User
    {
        //No discount is applied
        public override Discount GetDiscount()
        {
            return null;
        }

    }
}
