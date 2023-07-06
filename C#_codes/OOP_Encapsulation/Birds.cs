using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Encapsulation
{
    public class Birds
    {
        public int Number { get; private set; }
        public string Name { get; private set; }


        public int Numbers
        {
            set
            {
                Number = value;
            }
            
        }

        public string Names
        {
            set
            {
                Name = value;
            }
        }

        public void Info()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Number);
        }
    }
}
