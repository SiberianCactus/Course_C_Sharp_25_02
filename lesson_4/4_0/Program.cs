﻿// See https://aka.ms/new-console-template for more information

int sumNum(int num)
{
    int all_sum =0;
    for (int i = 1; i <= num; i++)
    all_sum += i;
return all_sum;
}

int A = int.Parse(Console.ReadLine()!);
int result = sumNum(A);
Console.WriteLine(result);
 