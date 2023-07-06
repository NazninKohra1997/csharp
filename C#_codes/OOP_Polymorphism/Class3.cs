using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    public class Class3
    {
        public void FunctionOverloading(int number)
        {
            Console.WriteLine(number);
        }

        public void FunctionOverloading(string name)
        {
            Console.WriteLine(name);
        }
    }
}
