using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_16
{
   public class Laptop
    {
        private string Name;
        private string Color { get; set; }

        public string NameOfLaptop
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }

        public string ColorOfLaptop
        {
            set
            {
                Color = value;
            }
        }

        public void GetLaptopInfo()
        {
            Console.WriteLine(NameOfLaptop);
            Console.WriteLine(Color);
        }
    }
}
