namespace PersonExample{
    public class Person{
        private int id;
        private string name;

        public int ID{
            get{
                return id;
            }
            set{
                id=value;
            }
        }

        public string Name{
            get{
                return name;
            }
            set{
                name=value;
            }
        }

        public void getInfo(){
            Console.WriteLine(id);
            Console.WriteLine(name);
        }
    }
}