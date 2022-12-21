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
    public class CourseEnrollment{
         public int UserId{get; set;}

         
         public User User{get; set;}
         public int CourseId{get; set;}
         public Course Course{get; set;}

        // public int CourseScheduleId{get; set;}
    }
}