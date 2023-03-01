// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);
if (a > b && a > c )
{
    Console.WriteLine("Большее число: а = " + a);
    if(b>c)
    {
          Console.WriteLine("Меньшее число: c = " + c);
    }
    else 
    {
      Console.WriteLine("Меньшее число: b = " + b);  
    }
}
else if(b > a && b > c)
{
   Console.WriteLine("Большее число: b = " + b);
   if(a>c)
    {
          Console.WriteLine("Меньшее число: c = " + c);
    }
    else 
    {
      Console.WriteLine("Меньшее число: a = " + a);  
    }
}
else  
{
     Console.WriteLine("Большее число: c = " + c);
     if(a>b)
      {
          Console.WriteLine("Меньшее число: b = " + b);
    }
    else 
    {
      Console.WriteLine("Меньшее число: a = " + a);  
    }
}



