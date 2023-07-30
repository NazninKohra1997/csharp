using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Default_Implementation
{
   public interface IWork
    {
        void Talk()
        {
            Console.WriteLine("Please talk!");
        }

        void Walk();
       
    }
}
