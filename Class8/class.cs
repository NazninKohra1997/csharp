namespace FinalizerExample{
    public class Person{
        public int roll=101;
        public string name="Raina";

        public void getInfo(){
            Console.WriteLine(roll);
            Console.WriteLine(name);
        }

        ~Person(){
           //this.name=null;
           //this.roll=0;
           Console.WriteLine("Finalizer calls");
        }
    }
}