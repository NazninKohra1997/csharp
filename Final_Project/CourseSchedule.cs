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
    public class CourseSchedule{
               public int Id{get; set;}
              
               public string StartingDate{get; set;}
               public string EndingDate{get; set;}

               public string Day{get; set;}
               public int TotalClasses{get; set;}

                public string TeacherName{get; set;}
                public string StudentName{get; set;}
              // public int CourseId{get; set;}
                public string NameOfCourse{get; set;}
               // public Course Course{get; set;}
                
               // public int UserId;
               // public string UserType{get; set;}
               // public User User{get; set;}
               



    }
}