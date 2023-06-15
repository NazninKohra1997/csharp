using EntityFramework_01;

TrainingDbContext context = new TrainingDbContext();

Number number = new Number();

number.Marks = 98;
number.Student_name = "Raisa";

Number number2 = new Number();
number2.Marks = 97;
number2.Student_name = "Raina";

context.Add(number);
context.Add(number2);
context.SaveChanges();