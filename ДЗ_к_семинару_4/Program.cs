// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Console.WriteLine("Введите первое чисол");
// double A = double.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите второе чисол");
// int B = int.Parse(Console.ReadLine()!);

// double Stepen(double A, int B)
// {
//     double result = A;
//     for (int i = 1; i < B; i++)
//     {
//         result = result * A;
//     }
//     return result;
// }
// double ytr = Stepen(A, B);
// Console.WriteLine($"Число {A} возведённое в степень {B} = {ytr}");


// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Console.WriteLine("Введите число");
// int number = int.Parse(Console.ReadLine()!);
// SumNum(number);

// int SumNum(int num)
// {
//     int sum = 0;
//     int newnum = num;
//     while (newnum != 0)
//     {
//         sum = sum + newnum % 10;
//         newnum = newnum / 10;
//     }
//     if (sum < 0) sum *= -1;
//     Console.WriteLine($"Сумма цифр в числе {num} = {sum}");
//     return sum;
// }



// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)
// int[] mas = new int[8];

// int[] ZapMas(int[] massiv)
// {   
//     for (int i = 0; i < massiv.Length; i++)
//     {
//         massiv[i] = new Random().Next(23, 98);
//     }
//     return massiv;
// }

// ZapMas(mas);
// Console.WriteLine($"Массив:[{String.Join(", ", mas)}]");