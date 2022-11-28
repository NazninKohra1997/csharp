namespace methodOverExample{
    public class Method{
        public int number1;
        public string name;

        public void OverGet(int Number ){
            number1+=Number;
        }

        public void OverGet(){
            Console.WriteLine(name);
            Console.WriteLine(number1);
        }
    }
}