void kvad(int x){
for ( int i = 1; i <= x; i++) 
{
    Console.WriteLine(i*i);
}
}

int a = int.Parse(Console.ReadLine()!);
kvad(a);