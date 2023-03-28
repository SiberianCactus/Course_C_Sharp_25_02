void ValuesSet(int M, int N)
	{
	    if (N < M) return;
	    ValuesSet(M , N- 1);
	    Console.Write($"{N} ");
	}

Console.WriteLine("Введите натуральнsе числа");
int num = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
ValuesSet(num, num2);