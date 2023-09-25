// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите следующее число ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите следующее число ");
int c = int.Parse(Console.ReadLine());
int max = a;
if (max < b) max = b;
if (max < c) max = c;
Console.Write("Максимальное из этих чисeл: ");
Console.Write(max);