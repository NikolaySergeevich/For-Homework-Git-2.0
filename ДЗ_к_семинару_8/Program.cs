// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

/*int[,] Masiv = CreatMas(5, 6);
PrintMas(Masiv);
Console.WriteLine();
MasivMaxMin(Masiv);
PrintMas(Masiv);

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
int[,] CreatMas(int M, int N)
{
    int[,] Arr = new int[M, N];
    for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < N; j++)
        {
            Arr[i, j] = new Random().Next(10);
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
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] MasivMaxMin(int[,] Arr)
{
    for (int i = 0; i < Arr.GetLength(0); i++)
    {
        for (int j = 0; j < Arr.GetLength(1) - 1; j++)
        {
            for (int k = j+1; k < Arr.GetLength(1); k++)
            {
                if (Arr[i,k] > Arr [i,j])
                {
                    int temp = Arr[i,k];
                    Arr[i,k] = Arr[i,j];
                    Arr[i,j] = temp;
                }
            }
        }
    }
    return Arr;
}
*/




// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



/*
int[,] Massiv = CreatMas(3, 4);
PrintMas(Massiv);
Console.WriteLine();
MassivMinSumSrting(Massiv);


int[,] CreatMas(int strin, int columb)
{
    int[,] Ar = new int [strin, columb];
    for (int i = 0; i < Ar.GetLength(0); i++)
    {
        for (int j = 0; j < Ar.GetLength(1); j++)
        {
            Ar[i,j] = new Random().Next(10);
        }
    }
    return Ar;
}

void PrintMas(int[,] Mas)
{
    for (int i = 0; i < Mas.GetLength(0); i++)
    {
        for (int j = 0; j < Mas.GetLength(1); j++)
        {
            Console.Write($"{Mas[i,j]} ");
        }
        Console.WriteLine();
    }
}



void MassivMinSumSrting(int[,] Masiv)
{
    int[] Array = new int [Masiv.GetLength(0)];
    for (int i = 0; i < Masiv.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < Masiv.GetLength(1); j++)
        {
            sum += Masiv[i,j]; 
        }
        Array[i] = sum;
    }
    int min = Array[0];
    int result = 1;
    for (int k = 0; k < Array.Length; k++)
    {
        if (Array[k] < min) 
        {
            min = Array[k];
            result = k+1;
        }
    }
    Console.WriteLine($"В двумерном массиве {result} строка с минимальной суммой элементов");

}
*/


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
/*Console.WriteLine("введите число, котораое будет соответствовать количеству"
                + " столбцов первой матрицы и количеству строк второй матрицы");
int numColStr = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число, которое будет соответствовать кличеству строк первой матрицы");
int str1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число, которое будет соответствовать кличеству столбцов второй матрицы");
int col2 = int.Parse(Console.ReadLine()!);

int[,] Matr1 = CreatMatrix1(str1, numColStr);
int[,] Matr2 = CreatMatrix2(numColStr, col2);
PrintMas(Matr1);
Console.WriteLine();
PrintMas(Matr2);
Console.WriteLine();
int[,] MatrixFin = Matrix1Matrix2(Matr1, Matr2);
PrintMas(MatrixFin);
///////////////////////////////////////////////////////////////

int[,] CreatMatrix1(int str, int countColStr)
{
    int[,] Matrix1 = new int[str, countColStr];
    for (int i = 0; i < Matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix1.GetLength(1); j++)
        {
            Matrix1[i, j] = new Random().Next(1, 6);
        }
    }
    return Matrix1;
}
int[,] CreatMatrix2(int countColStr, int col)
{
    int[,] Matrix2 = new int[countColStr, col];
    for (int i = 0; i < Matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix2.GetLength(1); j++)
        {
            Matrix2[i, j] = new Random().Next(1, 6);
        }
    }
    return Matrix2;
}
void PrintMas(int[,] Ar)
{
    for (int i = 0; i < Ar.GetLength(0); i++)
    {
        for (int j = 0; j < Ar.GetLength(1); j++)
        {
            Console.Write($"{Ar[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] Matrix1Matrix2(int[,] Mat1, int[,] Mat2)
{
    int result = 0;
    int[,] Matrix3 = new int[Mat1.GetLength(0), Mat2.GetLength(1)];
    for (int i = 0; i < Mat1.GetLength(0); i++)
    {
        for (int j = 0; j < Mat2.GetLength(1); j++)
        {
            for (int k = 0; k < Mat1.GetLength(1); k++)
            {
                result += Mat1[i, k] * Mat2[k, j];
            }
            Matrix3[i,j] = result;
            result = 0;
        }
    }
    return Matrix3;
}
*/




// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreatMas(int str, int col)
{
    int[,] Mas = new int[str,col];
    for (int i = 0; i < Mas.GetLength(0); i++)
    {
        for (int j = 0; j < Mas.GetLength(1); j++)
        {
            Mas[i,j] = 0;
        }
    }
    return Mas;
}
void PrintMas(int[,] Ar)
{
    for (int i = 0; i < Ar.GetLength(0); i++)
    {
        for (int j = 0; j < Ar.GetLength(1); j++)
        {
            Console.Write($"{Ar[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] Massiv = CreatMas(4,4);
PrintMas(Massiv);
Console.WriteLine();

int[,] FinMas(int st, int co,int num)
{
    if (Massiv[st, co] == 0)
    {
    Massiv[st, co] = num;
    FinMas(st, co, num + 1);
    return Massiv;
    }
    return Massiv;
}

FinMas(0,0,1);
PrintMas(Massiv);