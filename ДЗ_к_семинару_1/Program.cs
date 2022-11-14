// // Задача 8. Ввести число N и вывести все чётные от 1 до N
// Console.WriteLine("Введите число N");
// double N = int.Parse (Console.ReadLine()!);
// double number = 1;
// while (number <= N-1)
// {
// if (number%2 == 0)
//     {
//         Console.Write($"{number}, ");
//     }
//     number++;
// }
// while (number >= N)
// {
// if (number%2 == 0)
//     {
//         Console.Write($"{number}, ");
//     }
//     number--;
// }


// Задача 2. Написать программу, которая принимает на вход два числа и выдаёт, какое больше, а какое меньше.

// Console.WriteLine("Введите первое число");
// int num1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите второе число");
// int num2 = int.Parse(Console.ReadLine()!);
// int max = num1;
// if (max ==num2)
// {
//     Console.WriteLine("Первое и второе число равны");
// }
// if (max > num2)
// {
//     Console.WriteLine($"Максимальное число {num1}, а минимальное {num2}");
// }
// if (max < num2)
// {
// Console.WriteLine($"Максимальное число {num2}, а минимальное {num1}");
// }

// Задача 4. Написать программу, кторая принимает 3 числа и на выходе выдаёт максимальное из этих трёх.
// Console.WriteLine("Введите первое число");
// int num1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите второе число");
// int num2 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите третье число");
// int num3 = int.Parse(Console.ReadLine()!);
// int max = num1;
// if (max < num2)
// {
//     max = num2;
// }
// if (max < num3)
// {
//     max = num3;
// }
// Console.WriteLine($"Максимальное число {max}");

// Написать программу, которое принимает число и определяет чётное оно или нет
// Console.WriteLine("Введите число");
// int N = int.Parse(Console.ReadLine()!);
// if (N%2 == 0)
// {
//     Console.WriteLine($"Число {N} - чётное");
// }
// else 
// {
//     Console.WriteLine($"Число {N} - нечётное");
// }