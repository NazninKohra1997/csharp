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
    public class User{
         public int Id{get; set;}
         public string UserType{get; set;}

         public string Name{get; set;}

         public string Username{get; set;}
         public string Password{get; set;}

         public List<CourseEnrollment> UsersCourses{get; set;}

         
    }
}