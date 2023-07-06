using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstraction
{
    public abstract class Fruits
    {
        public string Name { get; private set; }
        public string Color { get; private set; }

        public Fruits(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public abstract void Info();
    }
}
