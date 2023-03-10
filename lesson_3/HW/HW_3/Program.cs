void cub(int x){
for ( int i = 1; i <= x; i++) 
{
    Console.WriteLine(Math.Pow(i, 3));
}
}

int a = int.Parse(Console.ReadLine()!);
cub(a);