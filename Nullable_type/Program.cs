using oop;

int? x=null;

x=5;

if(x.HasValue){
    Console.WriteLine(x.Value);
}
else{
    Console.WriteLine("null");
}




Person p= getName("Raisa");

Person getName(string Name){
    if(Name=="Raisa"){
        return new Person();
    }
    else{
        return null;
    }


}

p?.Talk("Hello");

int id=p?.id ?? 0;
Console.WriteLine(id);

