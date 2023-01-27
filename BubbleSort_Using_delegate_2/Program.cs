using Delegate;

Sorting<Person> sort=new Sorting<Person>();
//Person p=new Person();

List<Person> ls=new List<Person> ();
    ls.Add(new Person {Name="Jhora",Id=101} );
    ls.Add(new Person{Name="Raisa",Id=102});
    ls.Add(new Person{Name="Raisa",Id=100});
    ls.Add(new Person{Name="Sifat",Id=106});
    ls.Add(new Person{Name="Hafsa",Id=70});
var sorted=sort.BubbleSort(ls,Sort);

int Sort(Person x, Person y){
    if(x.Name==y.Name){
        if(x.Id==y.Id){
            return 0;
        }
        else if(x.Id>y.Id){
            return 1;
        }
        else{
            return -1;
        }
    }
    else{
        return x.Name.CompareTo(y.Name);
    }
}

foreach(var i in ls){
    Console.WriteLine($"Name: {i.Name}, Age:{i.Id}");
}