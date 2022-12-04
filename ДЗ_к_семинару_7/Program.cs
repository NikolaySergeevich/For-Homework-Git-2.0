// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

/*Console.WriteLine("Введите количество строк");
int P = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов");
int O = int.Parse(Console.ReadLine()!);
double[,] Mas = CreatMas(P,O);
PrintMas(Mas);


////////////////////////////////////////////////////////////////////////
double[,] CreatMas(int M, int N)
{
    double[,] Arr = new double [M,N];
    for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < N; j++)
        {
            Arr[i,j] = new Random().NextDouble() *10;
        }
    } 
    return Arr;
}
void PrintMas(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]:F2} ");
        }
        Console.WriteLine();
    }
}*/




// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// i = 5; j = 2 -> такого числа в массиве нет
// i = 1; j = 1 -> 9

/*Console.WriteLine("Введите количество строк");
int P = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов");
int O = int.Parse(Console.ReadLine()!);
int[,] Mas = CreatMas(P,O);
PrintMas(Mas);

Console.WriteLine("Укажите позицию строки");
int String = int.Parse(Console.ReadLine()!);
Console.WriteLine("Укажите позицию столбца");
int Сolumn = int.Parse(Console.ReadLine()!);
Poisk(String, Сolumn, Mas);



////////////////////////////////////////////////////////////////////////
int[,] CreatMas(int M, int N)
{
    int[,] Arr = new int [M,N];
    for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < N; j++)
        {
            Arr[i,j] = new Random().Next(10);
        }
    } 
    return Arr;
}
void PrintMas(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void Poisk(int Str, int Col, int[,] Mas)
{
    if (Str >= 0 && Str < Mas.GetLength(0) && Col >= 0 && Col < Mas.GetLength(1))
    {
        Console.WriteLine($"Элемент, который стоит на позиции {Str} {Col} = {Mas[Str, Col]}");
    }
    else
    {
    Console.WriteLine($"Элемента с такими позициями не существует");
    }
}
*/





// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

/*Console.WriteLine("Введите количество строк");
int P = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов");
int O = int.Parse(Console.ReadLine()!);
int[,] Mas = CreatMas(P,O);
PrintMas(Mas);
MathColl(Mas);


////////////////////////////////////////////////////////////////////////
int[,] CreatMas(int M, int N)
{
    int[,] Arr = new int [M,N];
    for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < N; j++)
        {
            Arr[i,j] = new Random().Next(10);
        }
    } 
    return Arr;
}
void PrintMas(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
void MathColl(int[,] Masiv)
{
    Console.Write($"Среднее арифметическое в столбцах = ");
    for (int i = 0; i < Masiv.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < Masiv.GetLength(0); j++)
        {
            sum += Masiv[j,i];
        }
        Console.Write($"{sum / Masiv.GetLength(0):f2}, ");
    }
}
*/

