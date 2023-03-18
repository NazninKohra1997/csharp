using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const_and_ReadOnly
{
    public class Member
    {
        public readonly int age;
        public const string name = "Jhora";

        public Member()
        {
            age = 25;
        }

        public void getInfo()
        {
            Console.WriteLine(name);
            Console.WriteLine(age);
        }
    }
}
