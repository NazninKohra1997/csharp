using System.Text;

string location="Bangladesh";
StringBuilder st=new StringBuilder(location);

st.Append(" love you!");
st.Replace(st[0],'b');

Console.WriteLine(st);
Console.WriteLine(st[0]);