


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