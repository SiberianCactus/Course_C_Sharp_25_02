void Trngl (int a, int b, int c)
{
      if(a < b+c && b < c+a&& c < a+b)
      Console.WriteLine("Это треугольник");
      else 
      Console.WriteLine("Это не треугольник ");
}

int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);

Trngl(a,b,c);
