// Задача 2: Напишите программу, которая выводит 
// случайное трёхзначное число и удаляет вторую цифру 
// этого числа.
int value = new Random().Next(100,1000);
Console.WriteLine(value);
Console.WriteLine(value/10%10);

