using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Mobile : Device
    {
        public string name = "Mobile";

        public string DeviceInfo()
        {
            return name;
        }
    }
}
