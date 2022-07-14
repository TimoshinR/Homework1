// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB =  int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int numberС = int.Parse(Console.ReadLine());

int max = numberA;

if (numberB > max) max = numberB;
if (numberС > max) max = numberС;

Console.Write("max = ");
Console.WriteLine(max);