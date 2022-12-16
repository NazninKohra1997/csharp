using EntityFrameworkExample;
TrainingDbContext context=new TrainingDbContext();
int a=0;
string st1="";
string st2="";




User user1=new User();
User user=new User();
User users=new User();


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
    }
    
    
   else{
       Console.WriteLine("Log In failed! Please ensure that you are admin Or check your username and password!");
   }






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



Console.WriteLine("Does Admin want to create a Student? If Yes press 1, else press 0!");
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

Console.WriteLine("Does Admin want to set a teacher in a Course? If Yes press 1 otherwise press 0!");
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
    string x2=Console.ReadLine();
    bool f1 = context.Users.Where(x => x.Id == x1 && x.Name==x2).Any();
    bool f2 = context.Users.Where(x => x.Id == x1 && x.UserType=="Teacher").Any();
    
    if(f1&&f2){
        Console.Write("Teacher ");
        Console.Write(x2);
        Console.Write(" is successfully assigned in course ");
        Console.WriteLine(name);
        Course course1=context.Courses.Where(x => x.Id == s).FirstOrDefault();
    if(course1.CoursesUsers==null){
    course1.CoursesUsers=new List<CourseEnrollment>();
    }
    course1.CoursesUsers.Add(new CourseEnrollment{UserId=x1});
    }
    else{
        Console.WriteLine("Please try again.Make sure you are assigning teacher from the current context or make a teacher.");
    }
      }
    else{
        Console.WriteLine("Course does not exist. Please try again or make a course!");
    }
      
    
    

    
   // Course course1=context.Courses.Where(x => x.Id == s).FirstOrDefault();
    //if(course1.CoursesUsers==null){
    //course1.CoursesUsers=new List<CourseEnrollment>();
    //}
     //Course1.CoursesUsers.Add(new CourseEnrollment{User=x1});

    
    
}
else{
    Console.WriteLine("Next!");
}

context.SaveChanges();







