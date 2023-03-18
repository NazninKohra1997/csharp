using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    public class Waterbottle
    {
        public int wateramount = 150;
        public string group = "Pran";


        public void GetInfo()
        {
            Console.WriteLine(wateramount);
            Console.WriteLine(group);
        }

        ~Waterbottle()
        {

        }
    }

}
