using EntityFrameworkExample;


TrainingDbContext context=new TrainingDbContext();

Teacher teacher1=new Teacher();

teacher1.Name="Mr. Khalil";
teacher1.Subject="Physics";

Teacher teacher2=new Teacher{
    
    Name="Mr. Karim",
    Subject="Math"
};




context.Add(teacher1);
context.Add(teacher2);

context.SaveChanges();
