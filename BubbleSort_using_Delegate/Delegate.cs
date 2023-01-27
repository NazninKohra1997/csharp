namespace Delegate{
    public class Sorting<T>{
        public delegate int Compare<T>(T a,T b);
        public IList<T> BubbleSort(IList<T> list,Compare<T> compare){
            T temp; 
            for(int i=0;i<list.Count-1;i++){
                for(int j=0;j<list.Count-1;j++){
                    int result=compare(list[j],list[j+1]);
                    if(compare(list[j],list[j+1])<0){
                        temp=list[j];
                        list[j]=list[j+1];
                        list[j+1]=temp;
                    }
                }
            }
             return list;
        }
           

    }
}