namespace StructurExample{
    public struct Person1{
        private string name;
        public int Id{get; private set;}

        public Person1(int Id,string name){
            this.Id=Id;
            this.name=name;
        }

        public string Name{
            get{
                return name;
            }
        }


    }
}