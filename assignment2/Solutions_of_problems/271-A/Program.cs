int year=int.Parse(Console.ReadLine());

for(int i=year+1; i<=12000; i++){
      int temp=i;
    
      
      string st= temp.ToString();

      char s1=st[0];
      char s2=st[1];
      char s3=st[2];
      char s4=st[3];

      if(s1!=s2 && s2!=s3 && s3!=s4 && s4!=s1 && s2!=s4 && s3!=s1){
        Console.WriteLine(temp);
        break;
      }

      
}