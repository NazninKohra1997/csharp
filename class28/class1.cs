namespace TupleExample{
    public class Person{
        private string name;
        public int Roll{get; private set;}
        public int Id=105;

        public Person(string name,int Roll){
            this.name=name;
            this.Roll=Roll;
        }

        public string Name{
            get{
                return name;
            }
        }
    }
}