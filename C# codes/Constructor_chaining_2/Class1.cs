using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_chaining_2
{
    public class Teacher
    {
       public string Name { get; set; } 
        public int ID { get; private set; }

        public int Age { get; private set; }

        public Teacher() : this("Jhora")
        {

        }
        public Teacher(string Name) : this (Name, 101)
        {
            this.Name = Name;
        }

        public Teacher(string Name, int ID) : this (Name, ID, 65)
        {
            this.Name = Name;
            this.ID = ID;
        }
        public Teacher(string Name, int ID, int Age) {
            this.Name = Name;
            this.ID = ID;
            this.Age = Age;
        
        }


        public void GetInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine(ID);
            Console.WriteLine(Age);
        }

    }
}
