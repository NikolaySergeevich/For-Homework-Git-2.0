// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите первое чисол");
double A = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе чисол");
int B = int.Parse(Console.ReadLine()!);

double Stepen(double A, int B)
{
    double result = A;
    for (int i = 1; i < B; i++)
    {
        result = result * A;
    }
    return result;
}

double ytr = Stepen(A, B);
Console.WriteLine($"Число {A} возведённое в степень {B} = {ytr}");