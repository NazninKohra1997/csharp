namespace EnumExample{
    public class Student{
        private string name;
        public int Id{get; private set;}
        public int Roll{get; private set;}

        public Student(string name,int Id,int Roll){
            this.name=name;
            this.Id=Id;
            this.Roll=Roll;
        }

        public string Name{
            get{
                return name;
            }
        }
    }
}