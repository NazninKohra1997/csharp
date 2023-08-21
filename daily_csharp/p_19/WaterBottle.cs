using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_19
{
    public class WaterBottle
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private int Capacity { get; set; }

        public WaterBottle(int Id, string Name, int Capacity)
        {
            this.Id = Id;
            this.Name = Name;
            this.Capacity = Capacity;

        }

        public int b_Id
        {
            get
            {
                return Id;
            }
        }
        public string b_Name
        {
            get
            {
                return Name;
            }
        }

        public int b_Capacity
        {
            get
            {
                return Capacity;
            }
        }

        public void GetWatterBottle()
        {
            Console.WriteLine(b_Id);
            Console.WriteLine(b_Name);
            if (Capacity > 500)
            {
                Console.WriteLine("Valid capacity!");
            }
            else
            {
                Console.WriteLine("Non valid capacity!");
            }
        }
    }
}
