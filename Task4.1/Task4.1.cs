﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();
Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int result=1;

NumPow(num1, num2);
Console.WriteLine(result);

int NumPow(int a, int b)
{
    for (int i = 1; i <= b; i++) result = result*a;
    return result;
}