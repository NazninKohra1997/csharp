using EntityFrameworkExample;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExample
{
    public class Teacher{
        
        public int Id{get; set;}
        public string Name{get; set;}
        public string Subject{get; set;}
       
    }
}