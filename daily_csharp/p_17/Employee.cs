using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_17
{
   public class Employee
    {
        private string Name { get; set; }
        private string Department { get; set; }
        private int Age { get; set;}


        public string NameOfEmployee
        {
            set
            {
                Name = value;
            }
        }

        public string DepartmentOfEmployee
        {
            set { 
            Department = value;
            }
        }

        public int AgeOfEmployee
        {
            set
            {
                Age = value;
            }
        }

        public void GetInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Department);
            Console.WriteLine(Age);
        }
    }
}
