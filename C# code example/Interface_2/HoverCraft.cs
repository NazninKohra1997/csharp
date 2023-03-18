using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_2
{
    public class HoverCraft : Car, Aeroplane
    {
        public void StartEngine()
        {
            Console.WriteLine("Start the Engine");
        }
    }
}
