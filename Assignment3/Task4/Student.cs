using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Student:Admin{
       

          public void GenerateId()
        {
             Id  = "ST-" + DateTime.Now.Ticks.ToString();
        }

        public Student():base("Md.","Karim","karim@gmail.com"){

        }

       

    
    
        
    }
    }
