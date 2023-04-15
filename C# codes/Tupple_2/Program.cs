using Tupple_2;
(int x, int y) r = new(11, 20);

Console.WriteLine(r.x);
Console.WriteLine(r.y);


(int roll, string name)[] student = new (int roll, string name)[3];

Student[] st = new Student[3];


 st[0] = new Student
{
    Name="Jhora",
    Roll=37
};

st[1] = new Student
{
    Name = "Raisa",
    Roll = 38
};

st[2] = new Student
{
    Name = "Raina",
    Roll = 39
};


for (int i = 0; i < st.Length; i++)
{
    student[i] = (st[i].Roll, st[i].Name);
}

foreach(var i in student)
{
    Console.WriteLine(i.name);
    Console.WriteLine(i.roll);
}