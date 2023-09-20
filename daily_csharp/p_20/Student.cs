using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_20
{
   public class Student
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public int Roll { get; private set; }


        public Student(int Id,  string Name, int Roll)
        {
            this.Id = Id;
            this.Name = Name;
            this.Roll = Roll;
        }

        public void GetInfo()
        {
            Console.WriteLine(Id);
            Console.WriteLine(Name);
            Console.WriteLine(Roll);
        }

        ~Student()
        {

        }
       
    }
}
