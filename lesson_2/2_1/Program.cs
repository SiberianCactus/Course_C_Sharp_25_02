int TakeNum(int num)
{
    Console.WriteLine(num);
    int res1 = num %10;
    int res2 = num / 10 ;
    if(res1 > res2)
    {
         return res1;
    }
    else 
    {
        return res2;
    }
}

int result = TakeNum(new Random().Next(10,100));
Console.WriteLine(result);