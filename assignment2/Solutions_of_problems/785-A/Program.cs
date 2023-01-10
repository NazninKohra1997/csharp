int num=int.Parse(Console.ReadLine());
int sum=0;

for(int i=0;i<num;i++){
    string st=Console.ReadLine();

    if(st=="Tetrahedron"){
        sum+=4;
    }
    else if(st=="Cube"){
        sum+=6;
    }
    else if(st=="Octahedron"){
        sum+=8;
    }
    else if(st=="Dodecahedron"){
        sum+=12;
    }
    else if(st=="Icosahedron"){
        sum+=20;
    }
}

Console.WriteLine(sum);