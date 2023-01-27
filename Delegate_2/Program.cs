using Delegate;

Student st=new Student();

st.Name1="Raisa";
st.Name2="Raina";

st.age1=15;

string ss=st.AttendanceSystem(Code);
Console.WriteLine(ss);

string Code(string s,string t,int y){
    string m=s+t;
   
    Console.WriteLine(y);
    return m;
}