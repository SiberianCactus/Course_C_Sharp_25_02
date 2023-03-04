// Задача 3: Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает, что третьей цифры 
// нет.

void func (string num)
{
    if (num.Length < 4 && num.Length > 2) 
    Console.WriteLine(num[2]);
    else if(num.Length < 3)
Console.WriteLine("третьей цифры нет");
else 
Console.WriteLine(num[2]);
}
func("1234");