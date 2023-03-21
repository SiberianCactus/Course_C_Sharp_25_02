void Func (double[] arr)
{
    int c = arr.Length;
    double[] newArray = new double[c];

    for (int i=0; i < c; i++)
    {
newArray[i] = arr[i];
Console.WriteLine(newArray[i]);
    }
}

double[] wow = {1.2,1.3,1.6};
Func(wow);