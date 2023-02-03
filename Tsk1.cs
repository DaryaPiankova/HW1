

Console.WriteLine("Input 2 numbers\n");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if(a>b){
    Console.WriteLine($"{a}>{b}\n");
}else if(a<b){
    Console.WriteLine($"{a}<{b}\n");
}else if(a==b){
    Console.WriteLine($"{a}=={b}\n");
}

