using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_overloading_for_negativity_of_fraction_
{
   public class Fraction
    {

        public int Num { get; set; }
        public int Den { get; set; }

        public static Fraction operator -(Fraction f1)
        {
            return new Fraction { Num = -f1.Num, Den = f1.Den };
        }
    }
}
