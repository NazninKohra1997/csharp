using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_keyword
{
   public class Calculator2 : Calculator
    {
        public new void Calculate()
        {
            
            Console.WriteLine("Calculate from calculator2");
        }
    }
}
