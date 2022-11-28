namespace ReadOnlyExample{
    public class Member1:Member{
        public Member1(int roll,int id):base(roll,id){
            
        }
        
        public new readonly int number=10000;
    }
}