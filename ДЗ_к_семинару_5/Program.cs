// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] Arr = Array(10);
// Console.WriteLine($"[{String.Join(", ", Arr)}]");
// CountNum(Arr);
// // --------------------------------------------
// int[] Array(int size)
// {
//     int[] Mas = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         Mas[i] = new Random().Next(100,1000);
//     }
//     return Mas;
// }

// int CountNum(int[] mass)
// {
//     int Count = 0;
//     foreach(int el in mass)
//     {
//         if (el % 2 == 0) Count += 1;
//     }
//     Console.WriteLine($"В массиве [{String.Join(", ", mass)}] имеется {Count} чётных чисел");
//     return Count;
// }



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях(индексы элементов должны быть нечетными(1,3,5 и тд)).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// int[] Ar = Array(10);
// Console.WriteLine($"[{String.Join(", ", Ar)}]");
// Summa(Ar);


// int[] Array(int size)
// {
//     int[] Mas = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         Mas[i] = new Random().Next(10);
//     }
//     return Mas;
// }

// int Summa (int[] nameMas)
// {   
//     int Sum = 0;
//     for (int i = 0; i < nameMas.Length; i++)
//     {
//         if( i % 2 != 0) Sum += nameMas[i];
//     }
//     Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {Sum}");
//     return Sum;
// }




// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// Console.WriteLine("Введите размер массива");
// int sizen = int.Parse(Console.ReadLine()!);
// int[] mas = Array(sizen);
// Console.WriteLine($"[{String.Join(", ", mas)}]");

// int Dln = Dlina(mas);
// Console.WriteLine($"Длина финишного массива = {Dln}");

//     int[] mas2 = Array2(mas, Dln);
//     int[] mas3 = Array3(mas, Dln);
//     if (mas.Length % 2 !=0)
//     {
//     Console.WriteLine($"[{String.Join(", ", mas2)}]");
//     }
//     else
//     {
//     Console.WriteLine($"[{String.Join(", ", mas3)}]");
//     }
// // -----------------------------------------------------------
// int[] Array(int size) // создаём массив 
// {
//     int[] Mas = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         Mas[i] = new Random().Next(10);
//     }
//     return Mas;
// }


// int Dlina(int[] array)
// {
//     int dlina = 0;
//     if (array.Length % 2 != 0)
//     {
//         dlina = array.Length / 2 + 1;
//     }
//     else
//     {
//         dlina = array.Length / 2;
//     }
//     return dlina;
// }




// int[] Array2(int[] massiv, int dlin) // длина массива нечётная
// {
//     int[] Finmas = new int[dlin];
//     int rigth = massiv.Length - 1;
//     for (int i = 0; i < rigth; i++)
//     {
//         int temp = massiv[i];
//         massiv[i] = massiv[rigth];
//         massiv[rigth] = temp;
//         Finmas[i] = massiv[i] * massiv[rigth];
//         rigth -= 1;
//     }
//      Finmas[Finmas.Length-1] = massiv[massiv.Length / 2];

//     return Finmas;
// }

// int[] Array3(int[] massiv, int dlin) // длина массива чётная
// {
//     int[] Finmas = new int[dlin];
//     int rigth = massiv.Length - 1;
//     for (int i = 0; i <= rigth; i++)
//     {
//         int temp = massiv[i];
//         massiv[i] = massiv[rigth];
//         massiv[rigth] = temp;
//         Finmas[i] = massiv[i] * massiv[rigth];
//         rigth -= 1;
//     }

//     return Finmas;
// }





// Задача 38: Задайте массив целых чисел от -10 до 10. Найдите разницу между максимальным и минимальным элементов массива.
// int[] Array = Arr(10);
// Console.WriteLine($"[{String.Join(", ", Array)}]");
// MaxMin(Array);
// ------------------------------------------------------------------------------------
// int[] Arr(int size)
// {
//     int[] Mas = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         Mas[i] = new Random().Next(-10, 11);
//     }
//     return Mas;
// }

// int MaxMin(int[] mas)
// {
//     int max = mas[0];
//     int min = mas[0];
//     foreach(int el in mas)
//     {
//         if (el > max) max = el;
//         if (el < min) min = el;
//     }
//     Console.WriteLine($"max = {max}, min = {min}");
//     return max;
// }



