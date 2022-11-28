namespace AbstractExample{
    public class Person1:Person{
        public Person1(string name,int Id):base(name,Id){

        }

        public int roll=102;

        public override int GetInfo(string name)
        {
            Console.WriteLine(name);
            return Id*roll;
        }
    }
}