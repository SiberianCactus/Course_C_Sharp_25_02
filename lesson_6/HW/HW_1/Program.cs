// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int Pos ( string[] num)
{
    int num_1 = 0;

for( int i = 0; i < num.Length; i++)
    if(int.Parse(num[i]) > 0) num_1++;
    return num_1;
}
Console.WriteLine("Введите числа через пробел");
string[] tokens = Console.ReadLine()!.Split();
Console.WriteLine("Количество положительных чисел: " + Pos(tokens));


