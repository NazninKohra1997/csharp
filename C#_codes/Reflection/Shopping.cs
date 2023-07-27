using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public abstract class Shopping
    {
        private string Name { get; set; }
        private double Price { get; set; }

        public Shopping(string Name, double Price)
        {
            this.Name = Name;
            this.Price = Price;
        }



        public virtual double PriceAfterDiscount(double discount)
        {
            var price = Price - (Price * discount / 100);
            return price;
        }
    }
}
