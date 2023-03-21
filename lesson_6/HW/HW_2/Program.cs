// // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Func (double  b1,double  k1, double b2, double k2)
{
     double  x = (b2-b1)/(k1-k2);
    double y=(k1*(b2-b1))/(k1-k2)+b1;
    Console.WriteLine($"({x}; {y} )");
}

double a = double.Parse(Console.ReadLine()!);
double b = double.Parse(Console.ReadLine()!);
double c = double.Parse(Console.ReadLine()!);
double d = double.Parse(Console.ReadLine()!);
Func(a,b,c,d);