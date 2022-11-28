namespace  oop{
    public partial class Form{
        private string name;
        private string email;

        public Form(string name,string email){
            this.name=name;
            this.email=email;

        }

        public string Name{
             get{
                return name;
             }
        }

        public string Email{
            get{
                return email;
            }
        }
    }

}