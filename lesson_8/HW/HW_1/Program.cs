// Задача 2: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j], 3} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to + 1);
    return arr;
}

void OrderElMin(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            for (int k = 0; k < column_size - j - 1; k++)
            {
                if (arr[i, k] < arr[i, k + 1])
                    (arr[i, k], arr[i, k + 1]) = (arr[i, k + 1], arr[i, k]);
        
            }
        }
    }
}

// int[] FrequencyDict(int[,] arr, int max_num)
// {
//     int[] freq = new int[max_num];

//     foreach (int item in arr) freq[item] += 1;
//     return freq;
// }

// void PrintMass(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//         Console.WriteLine($"{i} meets: {arr[i]}");
//     Console.WriteLine();
// }

Console.Write("Enter the number of rows: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column_num = int.Parse(Console.ReadLine()!);

int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);
int[,] mass = MassNums(row_num, column_num, start, stop);

Print(mass);

// int[] new_mass = OrderElMin(mass);
// PrintMass(new_mass);
OrderElMin(mass);
Print(mass);
