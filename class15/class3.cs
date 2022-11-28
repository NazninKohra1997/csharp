namespace AbstractExample{
    public class Person3:Person{
        public Person3(string name,int Id):base(name,Id){
     }

     public int number=100;

        public override int GetInfo(string name)
        {
            Console.WriteLine(name);
            return Id*number;
        }
    }
}