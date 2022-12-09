// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Write("Укажите количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;
int[] arr = new int[num];
FillArray(arr);
Console.Write($"В массиве {count} чётных чисел");

int[] FillArray(int[] a)
{
for (int i = 0; i<a.Length; i++)
{
    a[i] = new Random().Next(100,1000);
    if (a[i] % 2 == 0) count++;
}
return a;
}


