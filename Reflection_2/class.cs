namespace Reflection{
    public class Student:IStudent{
        private string name;

        public Student(string name){
            this.name=name;
        }

        public void Id(){
            Console.WriteLine($"{name}'s Id");
        }
    }
}