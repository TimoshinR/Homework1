// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());


int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);

int minSumNum = 0;
int sumNum = SumNumbers(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int temp = SumNumbers(array, i);
  if (sumNum > temp)
  {
    sumNum = temp;
    minSumNum = i;
  }
}

Console.WriteLine($"\n{minSumNum +1} - строкa с наименьшей суммой злементов равной {sumNum}");


int SumNumbers(int[,] array, int i)
{
  int sumNum = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumNum += array[i,j];
  }
  return sumNum;
}


void FillArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 10);
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
