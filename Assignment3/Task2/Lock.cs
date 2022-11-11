using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{

    public class Lock
    {

       public string lockstatus;


        public string LockStatus { 
            
            get{
                if(lockstatus=="Open" || lockstatus=="Close"){
                    return "Correct LockStatus!";
                }
                else{
                    return "Incorrect LockStatus!";
                }
            }

             set{
                lockstatus=value;
            } 
           
            } // Correct lock status are: Open & Close
    
   

    
}

}