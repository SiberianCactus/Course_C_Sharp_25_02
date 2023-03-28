// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные
// натуральные числа в промежутке от M до N с помощью рекурсии.

// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

void ValuesSet(int M, int N)
{
    if (N < M) return;
    ValuesSet(M, N - 1);
    if (N % 2 == 0)
    {
        Console.WriteLine(N);
    }

}

int numA = int.Parse(Console.ReadLine()!);
int numB = int.Parse(Console.ReadLine()!);

ValuesSet(numA, numB);
