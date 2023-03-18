using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Keyword
{
    public class Member2 : Member1
    {
        public override void  About()
        {
            Console.WriteLine("About member2");
        }
    }
}
