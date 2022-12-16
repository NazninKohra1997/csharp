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
    public class Parent{
        public int Id{get; set;}
        public string Son1{get; set;}
        public string Son2{get; set;}
        public string Son3{get; set;}
        
    }
}