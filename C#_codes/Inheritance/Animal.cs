using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
   public class Animal
    {

        public string Color { get; set; }
        private int Number { get; set; } 

        protected string Name { get; set; }

        public Animal(int Number) {
            this.Number = Number;
            Name = "Cat";
        }

        public void GetInfo()
        {
            Console.WriteLine(Color);
            Console.WriteLine(Name);
            Console.WriteLine(Number);
        }
    }
}
