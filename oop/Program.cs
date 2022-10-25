using oop;
public class program{
    public static void Main(string[] args){
           NewsPaper paper=new NewsPaper("black");

           paper.Number=210;
           Console.WriteLine(paper.Number);

           paper.Report();

           Console.WriteLine(paper.newsPaper);
    }
}
