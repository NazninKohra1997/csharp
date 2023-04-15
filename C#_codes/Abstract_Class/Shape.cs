using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    public abstract class Shape
    {
        public string Name { get; private set; }
        public string Color { get; private set; }

        public Shape(string Name, string Color)
        {
            this.Name = Name;
            this.Color = Color;
        }

        public void GetInfo()
        {
            Console.WriteLine("The information of shape class is");
            Console.WriteLine(Name);
            Console.WriteLine(Color);
        }

        public abstract void CalculateArea();
    }
}
