using Task4;

//For Admin
Admin ad=new Admin();
Console.WriteLine(ad.FullName);
Console.WriteLine(ad.Email);
ad.GenerateId();
Console.WriteLine(ad.Id);

Console.WriteLine();


//For Student
Student st=new Student();
Console.WriteLine(st.FullName);
Console.WriteLine(st.Email);
st.GenerateId();
Console.WriteLine(st.Id);
Console.WriteLine();


//For Teacher
Teacher tc=new Teacher();
Console.WriteLine(tc.FullName);
Console.WriteLine(tc.Email);
tc.GenerateId();
Console.WriteLine(tc.Id);



