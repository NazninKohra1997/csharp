int n=int.Parse(Console.ReadLine());

if(n==1){
        Console.Write("I hate it");
}
    else if(n>1){
        Console.Write("I hate that");
    }
    for(int i=2; i<n; i++)
    {

        if(i%2==1 && i!=n){
            Console.Write(" I hate that");
        }

        else if(i%2==0 && i!=n){
            Console.Write(" I love that");
        }
    }
    if(n%2==0 && n>1){
        Console.Write(" I love it");
    }
    else if(n>1){
        Console.Write(" I hate it");
    }