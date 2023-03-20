

void Fib (int num)
{
  int  a = 0;
  int b = 1;
    for (int i= 0; i < num; i++)
    {
          Console.Write(a + " " );
          (a,b) = (b, a+b);
    }
}
Console.WriteLine("Введите положительное число");
int Input = int.Parse(Console.ReadLine()!);
Fib(Input);
