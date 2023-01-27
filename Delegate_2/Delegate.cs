namespace Delegate{
    public class Student{
        public string Name1{get; set;}
        public string Name2{get; set;}

        public int age1{get; set;}

        public delegate string Attendance(string N1,string N2,int age1);

        public string AttendanceSystem(Attendance attend){
            string result=attend(Name1,Name2,age1);
            return result;

        }
    }
}