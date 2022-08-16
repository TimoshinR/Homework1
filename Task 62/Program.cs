// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

Console.Clear();

int m = 4;
int n = 4;
int[,] spiralArray = new int[m, n];

int temporary = 1;
int i = 0;
int j = 0;

while (temporary <= spiralArray.GetLength(0) * spiralArray.GetLength(1))
{
  spiralArray[i, j] = temporary;
  temporary++;
  if (i <= j + 1 && i + j < spiralArray.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= spiralArray.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > spiralArray.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(spiralArray);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($" {array[i,j]} ");
    }
    Console.WriteLine();
  }
}
