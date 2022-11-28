namespace InheriteExample{
    public class Member1:Member{
        private int id;

        public Member1(int id){
            this.id=id;
        }

        public int ID{
            get{
                return id;
            }
        }
    }
}