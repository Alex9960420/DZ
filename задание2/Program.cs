﻿// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x != 0 && y != 0)
{
    if (x > 0 && y > 0)
    {
      Console.WriteLine("1 четверть");  
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("2 четверть");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("3 четверть");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("4  четверть");
    }
}