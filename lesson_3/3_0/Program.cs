void quoters (int x, int y)
{
    if (x == 0 || y == 0)
    Console.WriteLine ("ERROR!");
    else if (x > 0 && y > 0)
    Console.WriteLine ("I");
       else if (x < 0 && y > 0)
    Console.WriteLine ("II");
       else if (x < 0 && y < 0)
    Console.WriteLine ("III");
       else if (x > 0 && y < 0)
    Console.WriteLine ("IV");
}

int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);

quoters(num1,num2);