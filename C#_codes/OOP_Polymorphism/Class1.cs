using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    public class Class1
    {
        public int Number { get; set; }

        public void FunctionOverride()
        {
            Console.Write("This is for class1 ");
            Console.WriteLine(Number);
        }
    }
}
