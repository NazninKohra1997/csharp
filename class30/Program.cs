using TExample;

Customer[] ct=new Customer[2];

ct[0]=new Customer(101){
    name="Rahim"
};

ct[1]=new Customer(102){
    name="Karim"
};


Order[] or=new Order[2];

or[0]=new Order("Shampoo"){
    name="Rahim"
};

or[1]=new Order("soap"){
    name="Karim"
};



(string name,int id,string product)[] Shop= new(string name,int id,string product)[2];

for(int i=0;i<ct.Length;i++){
    for(int j=0;j<or.Length;j++){
        if(ct[i].name==or[j].name){
            Shop[i]= (ct[i].name,ct[i].Id,or[i].Product);
        }
    }
}

foreach(var t in Shop){
    Console.Write(t.name);
    Console.Write(",");
    Console.Write(t.id);
    Console.Write(",");
    Console.WriteLine(t.product);
}