namespace ChainingExample{
    public class Patient{
        public string Name{get; private set;}
        public string Age{get; set;}
        public int Acount{get; set;}


        public Patient():this ("Jhora"){

        }
        public Patient(string Name):this(Name,"twelve",10000){
            this.Name=Name;
        }
        public Patient(string Name,string Age,int Acount){
            this.Name=Name;
            this.Age=Age;
            this.Acount=Acount;
        }
    }
}