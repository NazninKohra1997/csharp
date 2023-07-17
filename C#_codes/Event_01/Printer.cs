using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_01
{
   
     public class Printer
    {
        public delegate void DoSomething(string a);
        public event DoSomething something;

        public void Printed()
        {
            if(something != null)
            {
                something.Invoke("The work is done!");
            }
        }
    }

 }

