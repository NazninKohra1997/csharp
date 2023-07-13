using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_02
{
   public class Info
    {
        public string Item01 { get; set; }

        public delegate string DoSomething(string a);

        public void GetInfo(DoSomething something)
        {
            string name = Item01;
            Console.WriteLine(name);
        }
    }
}
