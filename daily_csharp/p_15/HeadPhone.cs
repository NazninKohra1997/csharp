using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_15
{
    public class HeadPhone
    {
        public string Color { get; set; }
        public int Number { get; set; }


        public void GetHeadPhone()
        {
            Console.WriteLine(Color);
            Console.WriteLine(Number);
        }
    }
}
