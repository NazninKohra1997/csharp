using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_05
{
   public class ShopKeeper<T> where T : class, new()
    {
        public T Name;
        public T Address;

    }
}
