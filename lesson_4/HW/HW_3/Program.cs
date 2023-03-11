// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] Array (int length){
    int[] R = new int[length];
    for(int i=0;i<length;i++)
    {
        R[i] = new Random().Next(10);
    }
    return R;
}

void Display (int[] arr)
{
     Console.Write("[");
for (int i = 0; i < arr.Length; i++)
{
    if (i < arr.Length-1)
     {
     Console.Write(arr[i] + ", ");
    }
    else
    {
        Console.Write(arr[i]);
    }
}
 Console.Write("]");
}

Display(Array(8));
