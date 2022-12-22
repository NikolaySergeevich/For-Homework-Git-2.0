Console.WriteLine("введите размер массива");
int num = int.Parse(Console.ReadLine()!);
CreatMas(num);
//////////////////////////////////////////////////////

void CreatMas(int number)
{
    string[] mas = new string[number];
    int count = 0;
    for (int i = 0; i < number; i++)
    {
        Console.WriteLine("Введите текст");
        string text = Console.ReadLine()!;
        mas[i] = text;
        if (mas[i].Length <= 3) count += 1;

    }
    Console.WriteLine($"[{String.Join(", ", mas)}]");
    Console.WriteLine($"Размер итогового массива = {count}");

    string[] Arr = new string[count];
    int j = 0;
    for (int i = 0; i < number; i++)
    {
        if (mas[i].Length <= 3)
        {
            Arr[j] = mas[i];
            j+=1;
        }
    }
    Console.WriteLine($"[{String.Join(", ", Arr)}]");

}







// void FinishMas(string[] Ar)
// {
//     int count = 0;
//     for (int i = 0; i < Ar.Length; i++)
//     {
//        if(Ar[i].Length <= 3)
//        count += 1; 
//     }
//     string[] Arr = new string[count];
//     for (int i = 0; i < count; i++)
//     {
//         for (int j = 0; j < Ar.Length; j++)
//         {
//             if(Ar[j].Length <= 3)
//             Arr[i] = Ar[j];
//         }
//     }
//     Console.WriteLine($"[{String.Join(", ", Arr)}]");
// }
