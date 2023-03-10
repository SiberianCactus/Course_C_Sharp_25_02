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
