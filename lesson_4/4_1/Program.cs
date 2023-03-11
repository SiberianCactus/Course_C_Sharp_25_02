// See https://aka.ms/new-console-template for more information

int sumNum(int num){
    int sum = 0;
    for (int i = 1; num > 0; i++){
        num = num / 10;
    sum = i;
    }
return sum;
}       

int A = int.Parse(Console.ReadLine()!);
int result = sumNum(A);
Console.WriteLine(result);
 