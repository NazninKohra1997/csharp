using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_01
{
   public class Printer
    {   
        public int Item01 { get; set; }
        public int Item02 { get; set; }

        public delegate int DoSomething(int a, int b);

        public void print(DoSomething something)
        {
            int sum = something(Item01,Item02);
            Console.WriteLine(sum);
        }
    }
}
