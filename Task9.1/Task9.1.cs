// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
// промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{PrintNumbers(N)}");

string PrintNumbers(int n)
{
    if (n == 1) return Convert.ToString(n); 
    else return Convert.ToString(n) + ", " + PrintNumbers(n - 1);
}
    