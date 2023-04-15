using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtual_Keyword_1
{
    public class Member1
    {
        public int Age { get; private set; }
        public string Name { get; private set; }

        public Member1(int Age, string Name) {
            this.Age = Age;
            this.Name = Name;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Age);
        }
    }
}
