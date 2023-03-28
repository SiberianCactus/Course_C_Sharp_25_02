void ValuesSet(int N)
	{
	    if (N == 0) return;
	    ValuesSet(N - 1);
	    Console.Write($"{N} ");
	}

Console.WriteLine("Введите натуральное число");
int num = int.Parse(Console.ReadLine()!);
ValuesSet(num);