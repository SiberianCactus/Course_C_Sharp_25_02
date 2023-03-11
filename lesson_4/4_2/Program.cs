// See https://aka.ms/new-console-template for more information

int sumNum(int num){
    int sum = 1;
    for (int i = 1; i <= num; i++){
        sum *= i;
    }
return sum;
}       

int A = int.Parse(Console.ReadLine()!);
int result = sumNum(A);
Console.WriteLine(result);
 