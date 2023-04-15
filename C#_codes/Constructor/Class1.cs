using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    public class Student
    {
        private string name;

        public Student(string name) {
            this.name = name;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }
    }
}
