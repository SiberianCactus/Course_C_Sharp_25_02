// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

void Print(double[] arr)
	{
	    int size = arr.Length;
	
	    for (int i = 0; i < size; i++)
	        Console.Write($"{arr[i]} ");
	    Console.WriteLine();
	}
	
	double[] MassNums(int size, double from, double to)
	{
	    double[] arr = new double[size];
	
	    for (int i = 0; i < size; i++)
	        arr[i] = new Random().NextDouble() * (to - from) + from;
	    return arr;
	}
	
	double MaxMin(double[] arr)
	{
	    double min = 10000;
	double max = 0;

	    for (int i = 0; i < arr.Length; i++)
	    {
	        if (arr[i] > max)
	            max = arr[i];
				else if(arr[i] < min)
				{
					min = arr[i];
				}
	
	    }
double result = max - min;
	    return result;
	}
	
	
	int num = int.Parse(Console.ReadLine()!);
	double start = double.Parse(Console.ReadLine()!);
	double stop = double.Parse(Console.ReadLine()!);
	double[] mass = MassNums(num, start, stop);
	Print(mass);
	Console.WriteLine (MaxMin(mass));