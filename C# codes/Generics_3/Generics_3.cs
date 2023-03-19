using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_3
{
    public class Coordinate<T> where T : class 
    {
        public T X { get; set; }
        public T Y { get; set; }
    }


}
