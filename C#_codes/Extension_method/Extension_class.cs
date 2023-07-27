using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Extension_method
{
    public static class Extension_class
    {
        public static List<int> Even (this List<int> list)
        {
            List<int> Even1 = new List<int>();
            foreach(var item in list)
            {
                if (item % 2 == 0)
                {
                    Even1.Add(item);
                }
            }

            return Even1;
        }
    }
}
