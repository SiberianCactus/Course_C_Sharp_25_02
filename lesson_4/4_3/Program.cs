void Array (int length){
    int[] R = new int[length];
    for(int i=0;i<length;i++)
    {
        R[i] = new Random().Next(2);

        Console.WriteLine(R[i]);
    }
}
Array(int.Parse(Console.ReadLine()!));