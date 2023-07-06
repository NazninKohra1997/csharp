using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstraction
{
   public class Mango : Fruits
    {
        public Mango() : base("Mango", "Green")
        {

        }

        public override void Info()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Color);
        }
    }
}
