// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.WriteLine("Введите первое число");
int nums = int.Parse(Console.ReadLine()!);
Console.WriteLine(Numbers(nums, 1));

int Numbers(int num, int fin)
{
    if (num != fin)
    {
        Console.Write($"{num}, ");
        return  Numbers(num - 1, fin);
    }
    return num;
}

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/*
Console.Write("Введите M: ");
int M = int.Parse(Console.ReadLine()!);

Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(Sum(M, N));

int Sum(int start, int finish)
{
    if(start == finish) return start;
    return start + Sum(start + 1, finish);
}
*/


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

/*Console.WriteLine("Введите число m: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(MetodAkermana(m, n));

int MetodAkermana(int numM, int numN)
{
    if(numM == 0) return numN + 1;
    else
    {
        if(numM != 0 && numN ==0) return MetodAkermana(numM - 1, 1);
        else
        {
            return MetodAkermana(numM - 1, MetodAkermana(numM, numN - 1));
        }
    }
    
    
}
*/