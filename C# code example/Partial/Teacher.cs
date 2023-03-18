using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial
{
   public partial class Teacher
    {
       public string Name { get; private set; }

        public void About()
        {
            Console.WriteLine(Name);
        }
    }
}
