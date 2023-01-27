using Delegate;

Sorting<int> st=new Sorting<int>();

List<int> ls=new List<int> {4,10,2,7,80,10};

var sorted = st.BubbleSort(ls,bubblesort);


int bubblesort(int a,int b){
    if(a==b){
        return 0;
    }
    else if(a<b){
        return 1;
    }
    else{
        return -1;
    }
}

foreach (int a in ls){
    Console.WriteLine(a);
}