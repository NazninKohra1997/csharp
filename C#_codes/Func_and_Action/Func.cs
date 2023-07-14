using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func_and_Action
{
   public class Func
    {
        public int Item1 { get; set; }
        public int Item2 { get; set; }

       // public delegate int DoSomething(int a, int b);

        public void Printer(Func<int,int,int> something)
        {
            int result = something(Item1, Item2);
            Console.WriteLine(result);  
        }
    }
}
