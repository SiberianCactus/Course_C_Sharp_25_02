// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int sumNum(int num)
{
    int all_sum = 0;
    for (int i = 1; num > 0; i++)
    {
    // num = num % 10;
    all_sum += num %10;
    num = num / 10;
    }
return all_sum;
}

int A = int.Parse(Console.ReadLine()!);
int result = sumNum(A);
Console.WriteLine(result);
 