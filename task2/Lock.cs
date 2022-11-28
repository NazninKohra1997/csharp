using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Lock
    {

       private string status; 
       
        public string LockStatus { 
            
            get{
                
                 return status;
               
               
            }
        
        set{
             if(value=="Open" || value=="Close"){
             status=value;           
        }
         else{
                    Console.WriteLine("InCorrect Lock Status!");
                }
               

          } // Correct lock status are: Open & Close
    }
}

}