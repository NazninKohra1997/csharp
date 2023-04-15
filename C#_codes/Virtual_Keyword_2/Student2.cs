using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Keyword_2
{
   public class Student2 : Student1
    {
        public int Id { get; set; }

        public Student2(string Name,int Age) : base(Name, Age)
        {

        }

        public override int GetInfo()
        {
            return Id;
        }
    }
}
