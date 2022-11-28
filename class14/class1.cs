namespace StaticExample{
    public  class Person{
        public static int number;

        private static int roll=5;

        public static void GetValue(){
            Console.WriteLine("Value is ok");
        }

        public  int Roll{
            get{
                return roll;
            }
        }
    }
}