﻿using EntityFrameworkExample;
TrainingDbContext context=new TrainingDbContext();
int a=0;
string st1="";
string st2="";
int ff=0;
string x2="";
int xy=50;





User user1=new User();
User user=new User();
User users=new User();
CourseEnrollment courseEnrollment1=new CourseEnrollment();


Console.WriteLine("Are you new here? If your answer is Yes then press 1, otherwise press 0!");
int ad=int.Parse(Console.ReadLine());
if(ad==1){
Console.WriteLine("Get registerd First!");
Console.WriteLine("Enter user Type:");
user.UserType=Console.ReadLine();
//if(user1.UserType=="Admin"){
Console.WriteLine("Enter Name:");
user.Name=Console.ReadLine();
Console.WriteLine("Enter UserName:");
user.Username=Console.ReadLine();
st1=user.Username;
Console.WriteLine("Enter Password:");
user.Password=Console.ReadLine();
st2=user.Password;
if(user.UserType=="Admin"){
    user1.UserType=user.UserType;
    user1.Name=user.Name;
    user1.Username=user.Username;
    user1.Password=user.Password;
context.Add(user1);
}
else{
    Console.WriteLine("");

}
}

    else{
    Console.WriteLine(" ");
    }
    
    
    Console.WriteLine();
    Console.WriteLine("Login now!");
    Console.WriteLine("Enter Username:");
    users.Username=Console.ReadLine();
    Console.WriteLine("Enter password");
    users.Password=Console.ReadLine();
    
    
    List<User> Users = context.Users.ToList();
    bool flag = context.Users.Where(x => x.Username == users.Username && x.Password==users.Password).Any();
    bool flag1 = context.Users.Where(x => x.UserType == "Admin" && x.Password==users.Password).Any();
    if((flag&&flag1) || (user.UserType=="Admin" && users.Username==st1 && users.Password==st2)){
        Console.WriteLine("You are succesfully loged In!");
        a=1;
        User user2=new User();
User user3=new User();

//List<AttendanceSystem> AttendanceSystems = context.AttendanceSystems.ToList();
//AttendanceSystem p = context.AttendanceSystems.Where(x => x.UserType == "Admin").FirstOrDefault();

if(a==1){
Console.WriteLine();
Console.WriteLine("Does Admin want to create a Teacher? If Yes Press 1, else press 0!");
int teacher=int.Parse(Console.ReadLine());
if(teacher==1){
user2.UserType="Teacher";
Console.WriteLine("Enter teacher's name:");
user2.Name=Console.ReadLine();
Console.WriteLine("Enter teacher's Username:");
user2.Username=Console.ReadLine();
Console.WriteLine("Enter teacher's Password:");
user2.Password=Console.ReadLine();
context.Add(user2);
Console.WriteLine();
}
else{
    Console.WriteLine("Next!");
}
Console.WriteLine();

context.SaveChanges();



Console.WriteLine("Does Admin want to create a Student? If Yes Press 1, else press 0!");
int student=int.Parse(Console.ReadLine());

if(student==1){
user3.UserType="Student";
Console.WriteLine("Enter student's Name:");
user3.Name=Console.ReadLine();
Console.WriteLine("Enter student's Username:");
user3.Username=Console.ReadLine();
Console.WriteLine("Enter student's Password:");
user3.Password=Console.ReadLine();
context.Add(user3);
}
else{
    Console.WriteLine("Next");
}
Console.WriteLine();
context.SaveChanges();


Course course=new Course();
Console.WriteLine("Does Admin want to create a Course? If Yes press 1, or press 0");
int cors=int.Parse(Console.ReadLine());
if(cors==1){
    Console.WriteLine("Enter the Course Name:");
    course.CourseName=Console.ReadLine();
    Console.WriteLine("Enter the Fees:");
    course.Fees=Console.ReadLine();
    context.Add(course);



}
else{
    Console.WriteLine("Next!");
}

}

context.SaveChanges();

Console.WriteLine("Does admin want to assign a teacher in a Course? If Yes press 1 otherwise press 0!");
int assignTeacher=int.Parse(Console.ReadLine());
if(assignTeacher==1){
    Console.WriteLine("Please enter Course Id:");
      int s=int.Parse(Console.ReadLine());
      Console.WriteLine("Enter Course Name:");
       string name=Console.ReadLine();
     //Course course1=context.Courses.Where(x => x.Id == s).FirstOrDefault();
     //Course course1=new Course();
      bool f = context.Courses.Where(x => x.Id == s && x.CourseName==name).Any();

      if(f){
        
      Console.WriteLine("Course exists in the current context.Now you can assign the teacher!");
      Console.WriteLine("Enter Teacher's Id:");
    int x1=int.Parse(Console.ReadLine());
    Console.WriteLine("Enter Teacher's name:");
     x2=Console.ReadLine();
    bool f1 = context.Users.Where(x => x.Id == x1 && x.Name==x2).Any();
    bool f2 = context.Users.Where(x => x.Id == x1 && x.UserType=="Teacher").Any();
    
    if(f1&&f2){
        ff=1;
        Console.Write("Teacher ");
        Console.Write(x2);
        Console.Write(" is successfully assigned in course ");
        Console.WriteLine(name);
        Course course1=context.Courses.Where(x => x.Id == s).FirstOrDefault();

        //here
         int count=0;
    if(ff==1){
          
            CourseSchedule courses1=new CourseSchedule();
           // CourseSchedule courses2=new CourseSchedule();
            
    Console.WriteLine("Please set the class schedule!");
    Console.WriteLine("Enter class starting time. For example, 7AM,8PM,10PM...");
    string o1=Console.ReadLine();
    Console.WriteLine("Enter class ending time. For example, 7AM,8PM,10PM...");
    string o2=Console.ReadLine();
    Console.WriteLine("Enter total number of classes:");
    int o3=int.Parse(Console.ReadLine());
   // int y=courses1.TotalClasses;
   
    Console.WriteLine("Enter the number of classes per week");
    int z=int.Parse(Console.ReadLine());
     string[]arr=new string[z];
    Console.WriteLine("Enter the day of classes.For example,Sunday,Monday...");

    for(int i=0;i<z;i++){
       arr[i]=Console.ReadLine();
    }
   // context.Add(courses1);


            Console.WriteLine("Please now assign students! please insert student from database or 1st make student ,then assign!");
           for(int i=0;i<o3;i++){
              xy=xy+1;
              
             Console.WriteLine("Enter Student's Id:");
              int x11=int.Parse(Console.ReadLine());
             Console.WriteLine("Enter Student's name:");
             string x22=Console.ReadLine();
             bool f11 = context.Users.Where(x => x.Id == x11 && x.Name==x22).Any();
             bool f22 = context.Users.Where(x => x.Id == x11 && x.UserType=="Student").Any();

             if(f11&&f22){
               courses1.Id=xy;
                courses1.TeacherName=x2;
               courses1.StartingDate=o1;
               courses1.EndingDate=o2;
               courses1.TotalClasses=o3;
               courses1.NameOfCourse=name;
                courses1.StudentName=x22;
                courses1.Day=arr[count];
                   count++;
                   if(count==z){
                    count=0;
                    }
                }
                
               
       // xx=1;
        Console.Write("Student ");
        Console.Write(x22);
        Console.Write(" is successfully assigned in course ");
        Console.WriteLine(name);
        //Course course1=context.Courses.Where(x => x.Id == x11).FirstOrDefault();
        
         // if(courses1.CoursesUsers==null){
    //course1.CoursesUsers=new List<CourseEnrollment>();
   // }
   // course1.CoursesUsers.Add(new CourseEnrollment{UserId=x11});//
    
context.Add(courses1);

   
    context.SaveChanges();
            }
    }
            else{
                Console.WriteLine("Student does not exit int the current context!");
            }

    

        //here
    
        
    if(course1.CoursesUsers==null){
    course1.CoursesUsers=new List<CourseEnrollment>();
    course1.CoursesUsers.Add(new CourseEnrollment{UserId=x1});

   

    //here
    }
    else{
        Console.WriteLine("A teacher already Assigned!");
    }
   
   
    }
    else{
        Console.WriteLine("Please try again.Make sure you are assigning teacher from the current context or make a teacher.");
    }
    
    //here

    
          //here
    

      }
    else{
        Console.WriteLine("Course does not exist in the current context. Please check Course Id and Name or make a course!");
    }
      
   
    
   //herrrrre
   
   //herrrre
    
    
}
else{
    Console.WriteLine("Next!");
}




    }
    
    
   else{
       Console.WriteLine("Log In failed! Please ensure that you are admin Or check your username and password!");
   }

context.SaveChanges();





