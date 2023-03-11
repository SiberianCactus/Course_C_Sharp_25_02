// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

void num (string x) {
    int j = 0;
    for (int i = 1; i < x.Length-1; i++) //3
    {
        if (x[i-1] == x[x.Length - i ]) 
        j = 1;
        else 
{
        j = 0;
        break;
}
    }
        if (j == 1)
    Console.WriteLine("Нет");
    else 
    {
    Console.WriteLine("Да");
    }
}

num("23432");
