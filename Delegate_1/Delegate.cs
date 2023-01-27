namespace Delegate
{
    public class Do{
        public int Item1{get; set;}
        public int Item2{get; set;}

        public delegate int DoSomething(int A,int B);

        public void Done(DoSomething something){
            int result=something(Item1,Item2);
            Console.WriteLine(result);
        }
    }
    
}