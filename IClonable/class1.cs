namespace IcloneExample{
    public class Person:ICloneable{
        public string Name{get; set;}
        public int Id{get;set;}

        public object Clone(){
            return new Person{Name=Name, Id=Id};
        }
    }
}