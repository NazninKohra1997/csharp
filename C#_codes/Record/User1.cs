using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Record
{
   public record User1 : User
    {
        public User1(string Name) : base(Name) { 
        
        }
    }
}
