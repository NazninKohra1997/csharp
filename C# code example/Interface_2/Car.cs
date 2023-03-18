using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_2
{
    public interface Car
    {
        public void StartEngine();

        public void StopEngine()
        {
            Console.WriteLine("From Car");
        }
    }
}
