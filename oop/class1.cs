namespace oop;
public class NewsPaper{
         private int number;
         private string color;

         public void Report(){
             Console.WriteLine("I'm reporter from desh news!");
         } 

         public int Number{
            get{
              return number;
            }
            set{
                number=value;
            }
         }

         public NewsPaper(string color){
            this.color=color;
         } 

         public string newsPaper{
            get{
                return color;
            }
         }
}