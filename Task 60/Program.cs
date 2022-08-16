// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

Console.Clear();

Console.WriteLine($"\nВведите размер массива X, Y, Z:");

Console.Write("Введите X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z: ");
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"");

int[,,] array = new int[x, y, z];
GetArray(array);
WriteArray(array);

void WriteArray (int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
      {
        Console.Write($"({i}, {j}, {k})={array[i,j,k]}  ");
      }
      Console.WriteLine();
    }
  }
}

void GetArray(int[,,] array)
{
  int[] temporary = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
  int  number;
  for (int i = 0; i < temporary.GetLength(0); i++)
  {
    temporary[i] = new Random().Next(10, 100);
    number = temporary[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temporary[i] == temporary[j])
        {
          temporary[i] = new Random().Next(10, 100);
          j = 0;
          number = temporary[i];
        }
          number = temporary[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array.GetLength(0); x++)
  {
    for (int y = 0; y < array.GetLength(1); y++)
    {
      for (int z = 0; z < array.GetLength(2); z++)
      {
        array[x, y, z] = temporary[count];
        count++;
      }
    }
  }
}
