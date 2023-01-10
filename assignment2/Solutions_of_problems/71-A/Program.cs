//string word=Console.ReadLine();
 
void fun(string word){
int length= word.Length;
 
//Console.WriteLine(length);
 
int word_length=length-2;
 
string string_length= word_length.ToString();
 
//Console.WriteLine(string_length);
 
   // Console.WriteLine(word[0]);
 
   if(length>10){
    Console.WriteLine(word[0]+string_length+word[length-1]);
   }
   else{
    Console.WriteLine(word);
   }
}
 
string words;
 
int input=int.Parse(Console.ReadLine());
 
for(int i=0;i<input;i++){
    words=Console.ReadLine();
    fun(words);
}