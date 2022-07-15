// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным. 6 -> да, 7 -> да, 1 -> нет


Console.WriteLine("Введите число от 1 до 7");
int num = int.Parse(Console.ReadLine());
if ((num > 0) & (num < 6))
{
    Console.WriteLine("Это рабочий день");
}
else if ((num == 6) || (num == 7))
{
   Console.WriteLine("Это выходной день");  
}
else 
{
Console.WriteLine("Нет такого дня недели");
}