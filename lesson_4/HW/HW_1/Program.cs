// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Stepen(int A, int B){
    int sum = 1;
    for (int i = 1; i <= B; i++){
       sum *= A;
       
    }
return sum;
}       

int A = int.Parse(Console.ReadLine()!);
int B = int.Parse(Console.ReadLine()!);
int result = Stepen(A,B);
Console.WriteLine(result);
 