int ValueSet(int N)
{
    if (N == 0)
        return 0;
    return ValueSet(N / 10) + N % 10;
}

Console.WriteLine("Введите натуральнsе числа");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine(ValueSet(num));
