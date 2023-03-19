using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtual_Keyword_1
{
    public class Member2 : Member1
    {
        public string Color { get; private set; }
        public Member2(int Age, string Name, string Color) : base (Age, Name )
        {
            this.Color = Color;
        }

        public override void GetInfo()
        {
            Console.WriteLine(Color);
        }
    }
}
