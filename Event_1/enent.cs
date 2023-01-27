namespace Event{
    public class Photoshoot{

        public event Action<string> OnClick;

        public void Click(){
            if(OnClick!=null){
                OnClick.Invoke("Shoot is done");
            }
        }
    }
}