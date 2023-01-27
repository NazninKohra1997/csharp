namespace Event{
    public class Fire{

        private int _Heat;
        public event Action<int> OverHeat;

        public void HeatAmount(){
            _Heat=0;
        }

        public void Firing(int speed){
            _Heat=speed*4;
            if(_Heat>500){
                OverHeat.Invoke(_Heat);
                Console.WriteLine("System is on fire!");
            }
            else{
                Console.WriteLine("System is okay");
            }
        }
    }
}