using oop1;

public class program{
    static void Main(string[] args){
        Member1 student=new Member1();

        student.Result=3.31;
        Console.WriteLine(student.Result);

        student.ageIs();

        Console.WriteLine(student.ID);
    }
}