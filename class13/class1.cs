namespace ConstantExample{
    public class Student{
        private const int roll=101;

        public const int number=100;
        
        public const string st="My name is jhora";

         public string ReturnValue(){
        return st;
        }

        public int Roll{
            get{
                return roll;
            }
        }

    }

   
}