// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4



int M = new Random().Next(1, 10);
Console.WriteLine($"Введите {M} чисел через Enter");
int[] Array = Arr(M);
Bolshe_0(Array);

// -----------------------------------------
int[] Arr(int Num)
{
    int[] mas = new int[Num];
    for (int i = 0; i < Num; i++)
    {
        int j = int.Parse(Console.ReadLine()!);
        mas[i] = j;
        j = 0;
    }
    Console.WriteLine($"[{String.Join(", ", mas)}]");
    return mas;
}

int Bolshe_0(int[] mas)
{
    int count = 0;
    foreach (int el in mas)
    {
        if (el > 0)
        {
            count += 1;
        }
    }
    Console.WriteLine($"{count} чисел строго больше 0");
    return count;
} 


// Задача 43: Написать программу, которая на вход принимает массив из любого
// количества элементов (не менее 6)в промежутке от 0 до 100, а на выходе выводит этот же массив,
// но отсортированный по возрастанию(от меньшего числа к большему).

// int size = new Random().Next(6, 11);
// int[] Ar = new int[size];

// CreatMas(Ar);
// MinMaxArr(Ar);
// // --------------------------------
// int[] CreatMas(int[] mas)
// {
//     for (int i = 0; i < mas.Length; i++)
//     {
//         mas[i] = new Random().Next(101);
//     }
//     Console.WriteLine($"[{String.Join(", ", mas)}]");
//     return mas;
// }

// int[] MinMaxArr(int[] arr)
// {
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         for (int j = i + 1; j < arr.Length; j++)
//         {
//            if (arr[j] < arr[i])
//            {
//             int temp = arr[i];
//             arr[i] = arr [j];
//             arr[j] = temp;
//            } 
//         }

//     }
//     Console.WriteLine($"[{String.Join(", ", arr)}]");
//     return arr;
// }


