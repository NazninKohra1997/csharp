namespace InherExample{
    public class Person{
        public string Name{get; set;}
        public int Roll{get; set;}
        public int Id{get; set;}

        public void Get(){
            Console.WriteLine("Person");
        }

        public Person(string Name,int Roll,int Id){
            this.Name=Name;
            this.Roll=Roll;
            this.Id=Id;
        }
    }
}