namespace Generics{
    public class Product:IProduct{
        public string Name{get;set;}
        public int price{get; set;}
        public void add(){
            Console.WriteLine("This is interface");
        }
    }
}