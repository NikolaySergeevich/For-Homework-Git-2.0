Console.WriteLine("Введите число N");
double N = int.Parse (Console.ReadLine()!);
double number = 1;
while (number <= N)
{
if (number%2 == 0)
    {
        Console.Write($"{number}, ");
    }
    number++;
}
