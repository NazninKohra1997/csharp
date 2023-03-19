using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    public class Circle : Shape
    {
        public int Radious { get; private set; }

        public Circle(int Radious, string Name, string Color) : base (Name, Color)
        {
            this.Radious = Radious;
        }

        public override void CalculateArea()
        {
            double area= Math.PI * Radious *Radious;
            Console.WriteLine("The area of circle is : ");
            Console.WriteLine(area);
        }
    }
}
