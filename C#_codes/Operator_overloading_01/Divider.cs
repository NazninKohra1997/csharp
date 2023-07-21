using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_overloading_01
{
    public class Divider
    {
        private readonly int Num;

        private readonly int Den;

        public Divider(int Num, int Den)
        {
            this.Num = Num;
            this.Den = Den;
        }

        public int Divide1
        {
            get
            {
                return Num;
            }
        }

        public int Divide2
        {
            get
            {
                return Den;
            }
        }

        public static Divider operator /(Divider d1,Divider d2)
        {
            return new Divider(d1.Num*d2.Den , d1.Den*d2.Num);
            

    }
       

    }
}
