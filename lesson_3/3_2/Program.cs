double example (double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2));
}

double a = double.Parse(Console.ReadLine()!);
double s = double.Parse(Console.ReadLine()!);
double d = double.Parse(Console.ReadLine()!);
double h = double.Parse(Console.ReadLine()!);
Console.WriteLine(example (a,s,d,h)); 