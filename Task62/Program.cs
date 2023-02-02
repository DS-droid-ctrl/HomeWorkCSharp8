// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

Console.Clear();

int[,] Matrix = new int[4, 4];

int number = 1;
int i = 0;
int j = 0;

while (number <= Matrix.GetLength(0) * Matrix.GetLength(1))
{
  Matrix[i, j] = number;
  number++;
  if (i <= j + 1 && i + j < Matrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= Matrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > Matrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

PrintArray(Matrix);

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}