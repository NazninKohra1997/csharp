using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Teacher:Admin{
         public void GenerateId()
        {
            Id = "TE-" + DateTime.Now.Ticks.ToString();
        }

         public Teacher():base("Md.","Basir","basir@gmail.com"){

        }
    }
}