namespace ReadOnlyExample{
    public class Member{
        private readonly int roll;
        public readonly int id;

        public readonly int number=102;

        public Member(int roll,int id){
            this.roll=roll;
            this.id=id;
        }

        public int Roll{
            get{
                return roll;
            }
        }
    }
}