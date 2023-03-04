void exploer (int num)
{
    if (num % 7 == 0 && num % 23 == 0 )
    Console.WriteLine("да");
    else
    Console.WriteLine("нет");

}
int num = int.Parse(Console.ReadLine()!);
exploer(num);