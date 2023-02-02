// Task54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива

Console.Clear();
Console.WriteLine("Введите размер двумерного массива:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[a, b];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
FillArrayReplace(matrix);
Console.WriteLine();
PrintArray(matrix);

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArrayReplace(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(1) - 1; k++)
            {
                if (matr[i, k] < matr[i, k + 1])
                {
                    int temp = matr[i, k + 1];
                    matr[i, k + 1] = matr[i, k];
                    matr[i, k] = temp;
                }
            }
        }
    }
}
