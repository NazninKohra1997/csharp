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
    public class Course{
        public int Id{get; set;}
        public string CourseName{get; set;}
        public string Fees{get; set;}
    }
}