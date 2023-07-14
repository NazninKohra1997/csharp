using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action
{
   public class Actions
    {

        public int Item3 { get; set; }
        public int Item4 { get; set; }

        public void Printer2(Action<int, int> something)
        {
            something(Item3, Item4);
           // Console.WriteLine(something);

        }
    }
}
