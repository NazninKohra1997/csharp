using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class InShopping : Shopping
    {
        public InShopping(string Name, double Price) : base(Name, Price) { 
            
        }

        public override double PriceAfterDiscount(double discount)
        {
            if(discount<0 || discount > 100)
            {
                 throw new InvalidCastException("Not applicable");
            }

            var discount2 = base.PriceAfterDiscount(discount);
            return discount2;

        }

    }
}
 