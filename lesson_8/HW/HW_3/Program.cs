// Задача 4: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j], 2} ");
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

int[,] MatrixProduct(int[,] arrFirst, int[,] arrSecond)
{
    int row1 = arrFirst.GetLength(0);
    int column1 = arrFirst.GetLength(1);

    int row2 = arrFirst.GetLength(0);
    int column2 = arrFirst.GetLength(1);

    int[,] pr_matrix = new int[row1, column1];

    if (column1 != row2)
        return pr_matrix;
    else if (column1 == row2)
        pr_matrix = new int[row1, column2];
    for (int i = 0; i < row1; i++)
    {
        for (int j = 0; j < column2; j++)
        {
            for (int p = 0; p < column1; p++)
            {
                pr_matrix[i, j] += arrFirst[i, p] * arrSecond[p, j];
            }
        }
    }
    return pr_matrix;
}

Console.Write("Enter the number of rows: ");
int row_num1 = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column_num1 = int.Parse(Console.ReadLine()!);

Console.Write("Enter the number of rows: ");
int row_num2 = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column_num2 = int.Parse(Console.ReadLine()!);

int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);
int[,] mass = MassNums(row_num1, column_num1, start, stop);
int[,] mass1 = MassNums(row_num2, column_num2, start, stop);

Print(mass);
Print(mass1);
Print(MatrixProduct(mass, mass1));