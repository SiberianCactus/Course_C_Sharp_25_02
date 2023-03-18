﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void Print(int[] arr)
	{
	    int size = arr.Length;
	
	    for (int i = 0; i < size; i++)
	        Console.Write($"{arr[i]} ");
	    Console.WriteLine();
	}
	
	int[] MassNums(int size, int from, int to)
	{
	    int[] arr = new int[size];
	
	    for (int i = 0; i < size; i++)
	        arr[i] = new Random().Next(from, to);
	    return arr;
	}
	
	int SumPosNeg(int[] arr)
	{
	    int num_2 = 0;
	
	    for (int i = 0; i < arr.Length; i++)
	    {
	        if (arr[i] % 2 == 0)
	            num_2++;
	
	    }
	    return num_2;
	}
	
	
	int num = int.Parse(Console.ReadLine()!);
	int start = int.Parse(Console.ReadLine()!);
	int stop = int.Parse(Console.ReadLine()!);
	int[] mass = MassNums(num, start, stop);
	Print(mass);
	Console.WriteLine (SumPosNeg(mass));