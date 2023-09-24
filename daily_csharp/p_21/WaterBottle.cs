using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_21
{
    public class WaterBottle
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Amount { get; private set; }


        public WaterBottle(int Id,  string Name, int Amount)
        {
            this.Id = Id;
            this.Name = Name;
            this.Amount = Amount;
        }

        public double WaterAmount(int amount)
        {
            double totalAmount = Amount + amount;
            return totalAmount;
        }

        public double WaterAmount(double amount)
        {

            return amount;
        }

        public void GetInfo()
        {
            Console.Write("Id is ");
            Console.WriteLine(Id);
            Console.Write("Name is ");
            Console.WriteLine(Name);
            Console.Write("Amount is ");
            Console.WriteLine(Amount);
        }
    }
}
