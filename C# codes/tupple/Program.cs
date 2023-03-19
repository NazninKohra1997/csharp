using tupple;


Member[] member = new Member[2];


member[0] = new Member()
{
    name = "Rahim",
    age = 30,
    id = 101
};

member[1] = new Member()
{
    name = "Karim",
    age = 35,
    id = 102
};

Experience[] experiences = new Experience[2];

experiences[0] = new Experience()
{
    name = "Rahim",
    topic = "C#"
};

experiences[1] = new Experience()
{
    name = "Karim",
    topic = "dotnet"
};


(string name, int id, string topic)[] r = new (string name, int id, string topic)[2];
int count = 0;

for(int i = 0; i < member.Length; i++)
{
    for(int j=0; j < experiences.Length; j++)
    {
        if (member[i].name == experiences[j].name)
        {
            r[count++] = (member[i].name, member[i].id, experiences[j].topic);
        }
    }
}


foreach(var i in r)
{
    Console.WriteLine($"{i.name},{i.id},{i.topic}");
}





