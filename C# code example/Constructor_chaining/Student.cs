using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_chaining
{
    internal class Student
    {
        private string name;
        private int age;
        

        public Student() : this("Raisa", 15)
        {

        }
        public Student(string name, int age)
        {
            this.name=name;
            this.age = age;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
        }
    }
}
