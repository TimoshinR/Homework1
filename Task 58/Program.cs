// Задача 58: 
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

Console.Clear();

Console.Write("Введите число строк массивов m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массивов n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] firstArray = new int[m, n];
FillArray(firstArray);
Console.WriteLine($"\nПервый массив:");
PrintArray(firstArray);

int[,] secomdArray = new int[m, n];
FillArray(secomdArray);
Console.WriteLine($"\nВторой массив:");
PrintArray(secomdArray);

int[,] resultArray = new int[m,n];

MultArray(firstArray, secomdArray, resultArray);
Console.WriteLine($"\nПроизведение соответствующих элементов массивов:");
PrintArray(resultArray);

void MultArray(int[,] firstArray, int[,] secomdArray, int[,] resultArray)
{
  for (int i = 0; i < resultArray.GetLength(0); i++)
    {
    for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            int mult = 0;
            mult = firstArray[i,j] * secomdArray[i,j];
            resultArray[i,j] = mult;
        }
    }
}

void FillArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 10);
    }
  }
}

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}
