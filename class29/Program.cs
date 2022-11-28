using TupExample;

Student[] st=new Student[2];

st[0]=new Student{
    Name="Rahim",
    Roll=101
};

st[1]=new Student{
    Name="Karim",
    Roll=103
};


(string name,int roll)[] student= new(string name,int roll)[2];
for(int i=0;i<st.Length;i++){
       student[i]=(st[i].Name,st[i].Roll);
}

foreach(var j in student){
    Console.Write(j.name);
    Console.Write(",");
    Console.WriteLine(j.roll);
}