// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом(первое число равно последнему, второе равно предпоследнему).

// Console.WriteLine("Введите пятизначное число");
// int num = int.Parse(Console.ReadLine()!);
// if (num > -100000 && num <= 10000 || num >= 10000 && num < 100000)
// {
//     if(num / 10000 == num % 10 && num / 1000 % 10 == num / 10 % 10)
//     {
//         Console.WriteLine($"Число {num} - палиндром");
//     }
//     else
//     {
//         Console.WriteLine($"Число {num} палиндромом не является");
//     }
// }
// else
// {
//     Console.WriteLine("Введённое число не пятизначное");
// }




// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// Console.WriteLine("Введите координату точки A по оси X");
// int Xa = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите координату точки A по оси Y");
// int Ya = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите координату точки A по оси Z");
// int Za = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите координату точки B по оси X");
// int Xb = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите координату точки B по оси Y");
// int Yb = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите координату точки B по оси Z");
// int Zb = int.Parse(Console.ReadLine()!);

// double distantsAB = Math.Sqrt(Math.Pow(Xb - Xa, 2) + Math.Pow(Yb - Ya, 2) + Math.Pow(Zb - Za, 2));
// Console.WriteLine($"Расстояние между точкой A и B = {distantsAB}");


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// Console.WriteLine("Введите число N");
// int num = int.Parse(Console.ReadLine()!);

// for (int kubnum = 1; kubnum<=num; kubnum++)
// {
//     int kub = Convert.ToInt32(Math.Pow(kubnum, 3));
//     Console.Write($"{kub}; ");
// }
// for (int kubnum = 1; kubnum >= num; kubnum--)
// {
//     int kub = Convert.ToInt32(Math.Pow(kubnum, 3));
//     Console.Write($"{kub}; ");
// }