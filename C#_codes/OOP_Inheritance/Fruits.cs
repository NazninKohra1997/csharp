using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    public class Fruits
    {

        public string Mango { get; private set; }
        public int Number { get; private set; }

        public Fruits(string Mango, int Number)
        {
            this.Mango = Mango;
            this.Number = Number;
        }
    }
}
