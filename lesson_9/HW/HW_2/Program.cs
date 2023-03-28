// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int ValuesSet(int M, int N)
	{
	    if (N < M) return 0;
	    return ValuesSet(M , N- 1) + N;
	}

int numA = int.Parse(Console.ReadLine()!);
int numB = int.Parse(Console.ReadLine()!);

Console.WriteLine(ValuesSet(numA, numB));