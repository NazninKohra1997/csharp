using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_18
{
    public class Fruits
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private string Color { get; set; }
        

        public Fruits(int Id,  string Name, string Color)
        {
            this.Name = Name;
            this.Id = Id;
            this.Color = Color;
        }

        public int f_Id
        {
            get
            {
                return Id;
            }
        }
        public string f_Name
        {
            get
            {
                return Name;
            }
        }

        public string f_Color
        {
            get
            {
                return Color;
            }
        }

        public void GetFruitInfo()
        {
            Console.WriteLine(f_Name);
            Console.WriteLine(f_Color);
            Console.WriteLine(f_Id);
        }
    }
}
