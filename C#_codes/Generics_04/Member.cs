using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_04
{
   public class Member<T> where T : struct
    {
        public T Type { get; set;}
    }
}
