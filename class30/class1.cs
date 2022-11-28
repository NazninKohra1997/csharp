namespace TExample{
    public class Customer{
        public string name;
        private int id;
        public Customer(int id){
            this.id=id;
        }

        public int Id{
            get{
                return id;
            }
        }
    }
}