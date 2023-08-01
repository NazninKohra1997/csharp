using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Record
{
   public record User 
    {
        private string Name { get; set; }
        
        public User(string Name)
        {
            this.Name = Name;
        }

        public string NameP
        {
            get{
                return Name;
            }
        }

        public void GetName()
        {
            Console.WriteLine(Name);
        }

    }
}
