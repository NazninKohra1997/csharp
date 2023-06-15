using EntityFramework_update;

TrainingDbContext context = new TrainingDbContext();

/*Account account = new Account();

account.Title = "C#";
account.Number = 101;

Account account1 = new Account();

account1.Title = "C++";
account1.Number = 102;

context.Add(account);
context.Add(account1);
*/

/*   For update
 Account a1 = context.Accounts.Where((x) => x.Title == "C++").FirstOrDefault();
a1.Title = "C";
a1.Number = 10;*/


//for delete
Account a2 = context.Accounts.Where((x)=>x.Id == 1).FirstOrDefault();
context.Accounts.Remove(a2);
context.SaveChanges();