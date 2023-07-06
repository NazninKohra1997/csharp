using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
   public class Class2 : Class1
    {

        public int Id { get; set; }

        public void FunctionOverride()
        {
            Console.Write("This is Id ");
            Console.WriteLine(Id);
        }
    }
}
