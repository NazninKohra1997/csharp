using EntityFrameworkExample;


TrainingDbContext context=new TrainingDbContext();

//for inserting data in table
/*Parent p1=new Parent{
    Son1="Moga",
    Son2="Mofiz",
    Son3="Mokles"
};

Parent p2=new Parent{
    Son1="Mou",
    Son2="Moin",
    Son3="Mohi"
};

context.Add(p1);
context.Add(p2);
context.SaveChanges()*/


//for update or change existing data
/*List<Parent> Parents = context.Parents.ToList();
Parent p = context.Parents.Where(x => x.Son1 == "Moga").FirstOrDefault();
p.Son1="Mahi";
p.Son2="Nahi";

context.SaveChanges();*/


//for delete data
/*Parent p = context.Parents.Where(x => x.Son1 == "Mou").FirstOrDefault();
context.Parents.Remove(p);
context.SaveChanges();*/



