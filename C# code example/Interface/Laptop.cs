using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Laptop : Device
    {
        public string name = "Laptop";

        public string DeviceInfo()
        {
            return name;
        }
    }
}
