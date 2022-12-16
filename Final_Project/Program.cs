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







