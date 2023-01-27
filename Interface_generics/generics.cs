namespace Generics{
    public class Shop<T> where T:IProduct{
        public void AddItem(T Item){
             Console.WriteLine("All about interface!");
        }
    }
}