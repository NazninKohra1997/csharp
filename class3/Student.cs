namespace StudentExample{
    public class Student{
        private int roll;
        private string name;

        public void getInfo(){
            Console.WriteLine(roll);
            Console.WriteLine(name);
        } 


        public Student(int roll,string name){
            this.roll=roll;
            this.name=name;
        }

        public int Roll{
            get{
                return roll;
            }
        }

        public string Name{
            get{
                return name;
            }
        }
    }


}