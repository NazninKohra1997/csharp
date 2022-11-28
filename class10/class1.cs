namespace Inherite{
    public class Member{
        protected string name;

        private int roll;

        public int ID{get; private set;}
        
        public Member(string name, int roll, int ID){
            this.name=name;
            this.roll=roll;
            this.ID=ID;
        }

        public string Name{
            get{
                return name;
            }
        }

        public int Roll{
            get{
                return roll;
            }
        }
    }
}