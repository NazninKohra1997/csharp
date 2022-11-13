using oop;

Persons[] person=new Persons[2];
person[0]=new Persons{
    name="Rahim",
    Id=101,
    age=24
};

person[1]=new Persons{
    name="Karim",
    Id=102,
    age=23
};


Order[] order=new Order[2];
order[0]=new Order{
    name="Rahim",
    soap=400
};

order[1]=new Order{
    name="Karim",
    soap=300
};

(int soap,int id)[] tt=new (int soap,int id )[2]; 
for(int i=0;i<person.Length;i++){
    for(int j=0;j<order.Length;j++){
        if(person[i].name==order[j].name){
           tt[i]=(person[i].Id,order[j].soap);
        }
    }
}

for(int i=0;i<tt.Length;i++){
    Console.WriteLine(tt[i]);
}