int number=int.Parse(Console.ReadLine());
var arr= new int[number,number];

for(var i=0;i<number;i++){
    var num=new string[number];
    num=Console.ReadLine().Split();
    for(var j=0; j<number;j++){
        
        arr[i,j]=int.Parse(num[j]);
    }
}

for(int i=0;i<number;i++){
    for(int j=0;j<number;j++){
    Console.Write(arr[i,j]);
    Console.Write(" ");
    }
}
