// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int count = 0;
int result = 1;

while (count < number)
{
    if (result % 2 == 0)
    Console.WriteLine(result);
    result = result + 1;
    count++;
}
