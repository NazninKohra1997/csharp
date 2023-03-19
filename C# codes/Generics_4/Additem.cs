using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_4
{
    public class Additem<T> where T : IProduct
    {
        public void Addi(T item)
        {
            Console.WriteLine(item);
        }
    }
}
