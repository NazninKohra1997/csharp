namespace TExample{
    public class Order{
        public string name;

        private string product;

        public Order(string product){
            this.product=product;
        }

        public string Product{
            get{
                return product;
            }
        }
    }
}