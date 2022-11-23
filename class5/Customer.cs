namespace CustomerExample{
    public class Customer{
        private int id;
        private string name;
        private string product;

        public void CustInfo(){
            Console.WriteLine(id);
            Console.WriteLine(name);
            Console.WriteLine(product);
        }

        
        public Customer():this(101){

        }
        public Customer(int id):this(id,"Raju"){
            this.id=id;
        }
        public Customer(int id,string name):this(id,name,"shampoo"){
            this.id=id;
            this.name=name;
        }       
         public Customer(int id,string name,string product){
            this.id=id;
            this.name=name;
            this.product=product;
        }
    }
}