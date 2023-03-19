using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_chaining_3
{
   public class Member
    {
        public int ID { get; private set; }
        public int Age { get; private set; }
        public int Number{ get; private set; }


        public Member() : this(101,26, 01974520266)
        {

        }
        public Member(int ID, int Age, int Number)
        {
            this.ID = ID;   
            this.Age = Age;
            this.Number = Number;
        }

        public void GetInfo()
        {
            Console.WriteLine(ID);
            Console.WriteLine(Age);
            Console.WriteLine(Number);
        }
    }
}
