using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Default_Implementation
{
    public class Work : IWork
    {

        public void Walk()
        {
            Console.WriteLine("I'm walking");
        }
    }
}
