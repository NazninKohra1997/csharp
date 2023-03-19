using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Keyword_2
{
    public abstract class Student1
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Student1(string Name, int Age) {
            this.Name = Name;
            this.Age = Age;
        }

        public virtual int GetInfo()
        {
            //Console.WriteLine(Name);
            return Age;
        }
    }
}
