using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_07
{
   public class Parcel<T> where T : IProduct
    {
        public T Address { get; set; }
    }
}
