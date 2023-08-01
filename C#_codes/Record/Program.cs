using Record;

User user = new User("Jhora");
User user1 = new User("Jhora");

//user1.GetName();


if(user == user1)
{
    Console.WriteLine("It's record!");
    Console.WriteLine(user.NameP);
}
else
{
    Console.WriteLine("Not same");
}