namespace AbstractExample{
    public abstract class Person{
        private string name;
        public int Id{get; private set;}

         public Person(string name,int Id){
        this.name=name;
        this.Id=Id;
        }

        public string Name{
            get{
                return name;
            }
        }

        
        public abstract int GetInfo(string name);
    } 

   
} 