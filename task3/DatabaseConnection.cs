using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class DatabaseConnection
    {
        private readonly string connectionString;  //creating readonly field
        public DatabaseConnection(string connectionString)
        {
             this.connectionString=connectionString;
        }

        public string Data{
             get{
                return connectionString;
             }
        }
    }
}
