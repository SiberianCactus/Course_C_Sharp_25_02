// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void cub(int x){
for ( int i = 1; i <= x; i++) 
{
    Console.WriteLine(Math.Pow(i, 3));
}
}

int a = int.Parse(Console.ReadLine()!);
cub(a);