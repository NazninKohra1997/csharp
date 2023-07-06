using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
   public class Mango : Fruits
    {
        public string Nam { get; private set; }
        public Mango(string Nam) : base("Rupali", 33)
        {
           this.Nam = Nam;
        }
       
    }
}
