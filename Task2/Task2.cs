﻿// Задача 2: Напишите программу, 
// которая на вход принимает два числа и 
// выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"Максимальное число: {num1}");
    Console.WriteLine($"Минимальное число: {num2}");
}
else if (num1 == num2)
{
    Console.WriteLine($"Введенные числа равны: {num1} = {num2}");
}
else 
{
    Console.WriteLine($"Максимальное число: {num2}");
    Console.WriteLine($"Минимальное число: {num1}");
}