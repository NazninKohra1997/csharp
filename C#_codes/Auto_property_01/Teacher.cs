using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_property_01
{
    public class Teacher
    {

        public int ID { get; private set; }

        public Teacher(int ID)
        {
            this.ID = ID;
        }


    }
}
