//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
//
//  Console.Write($"у числа {n} нету третей цифры");
//  Console.Write($"у числа {n} нету третей цифры");



int Prompt(string msg)
{
Console.WriteLine($"{msg}");
return Convert.ToInt32(Console.ReadLine());
}
int n = Prompt("Введите число");
int n1(int n)
{
while (n > 999)
{
n /= 10;
}
return n % 10;
}

bool check(int n)
{
if (n < 100)
return false;
else return true;
}

if (check(n) != true)
Console.WriteLine("Третьей цифры нет");
else
Console.WriteLine($"Третья цифра числа {n} является {n1(n)}");