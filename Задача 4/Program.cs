﻿Console.WriteLine("Введите номер четверти: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 4)
{
    Console.WriteLine("Ошибка.");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n == 1)
    Console.WriteLine("x > 0, y > 0");
if (n == 2)
    Console.WriteLine("x < 0, y > 0");
if (n == 3)
    Console.WriteLine("x < 0, y < 0");
if (n == 4)
    Console.WriteLine("x > 0, y < 0");
