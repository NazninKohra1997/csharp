using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_03
{
    public class Product<T> where T : class
    {
        public T Id { get; set; }
    }
}
