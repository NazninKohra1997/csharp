namespace Reflection{
    public class Report:IReflection{
        private string name;
        public Report(string name){
            this.name=name;
        }

        public void start(){
            Console.WriteLine($"Run the program : {name}");
        }
    }
}