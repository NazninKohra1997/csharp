using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_4
{
    public class Customer : IProduct
    {
        public int Id { get; set; }

        public void Add()
        {
            Console.WriteLine("All is well");
        }
    }
}
