namespace  Event
{
    public class Do{
        public event Action<int> Done;
        public void DoWork(){
            if(Done!=null){
                Done.Invoke(22);

            }
        }
    }
    
}