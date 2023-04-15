using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_06
{
   public class Flowers<T>
    {
        public T Name { get; set; }

        public T Func(T color)
        {
            return color;
        }
    }
}
