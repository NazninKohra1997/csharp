using Delegate;

Sorting<Student> st= new Sorting<Student>();

List<Student> ls=new List<Student>();

ls.Add( new Student{Name="Raisa", Age=10} );
ls.Add( new Student{Name="Raina", Age=12} );
ls.Add( new Student{Name="Hafsa", Age=9} );

var so=st.BubbleSort(ls,Sort);



int Sort(Student X, Student Y){
    if(X.Name==Y.Name){
        if(X.Age==Y.Age){
            return 0;
        }
        else if(X.Age<Y.Age){
            return 1;
        }
        else{
            return -1;
        }
    }
    else{
        return X.Name.CompareTo(Y.Name);
    }
}

foreach(var i in ls){
    Console.WriteLine($"Name:{i.Name}  Age:{i.Age}");
}