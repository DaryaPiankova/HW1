Console.WriteLine("Input 3 numbers\n");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if (a>b){
    if(a>c){
        Console.WriteLine($"{a} is the biggest number\n");
    }else if (b>c){
        Console.WriteLine($"{b} is the biggest number\n");
    }else if(c>b){
        Console.WriteLine($"{c} is the biggest number\n");
    }
}else if(b>c){
    Console.WriteLine($"{b} is the biggest number\n");
}else if(c>b){
    Console.WriteLine($"{c} is the biggest number\n");


