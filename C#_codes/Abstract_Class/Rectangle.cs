using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
   public class Rectangle : Shape
    {
        public int Height { get; private set; }
        public int Width { get; private set; }

        public Rectangle(int Width, int Height, string Name, string Color) : base(Name, Color)
        {
            this.Width = Width;
            this.Height = Height;
        }

        public override void CalculateArea()
        {
            int area = Height * Width;
            Console.WriteLine("The area of rectangle is : ");
            Console.WriteLine(area);
        }

    }
}
