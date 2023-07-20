using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_overloading
{
    public class Fraction
    {
        public int Num { get; set; }
        public int Den { get; set; }

        public static Fraction operator +(Fraction f1, Fraction f2){
                return new Fraction{Num = f1.Num * f2.Den + f2.Num * f1.Den, Den = f1.Den * f2.Den};
            }
    }
}
