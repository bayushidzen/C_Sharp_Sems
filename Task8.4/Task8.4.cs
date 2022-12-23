﻿// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
int sideX = 3;
int sideY = 3;
int sideZ = 3;
int maxRandom = 1000;
int[,,] arr3 = new int[sideX, sideY, sideZ];
int[] arrShuffle = new int[maxRandom];
FillArray(arr3,RandomShuffle(arrShuffle));

int[,,] FillArray(int[,,] a,int[] b)
{ Console.WriteLine();
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            for (int k = 0; k < a.GetLength(2); k++)
            {
                int h = new Random().Next(0, b.Length);
                a[i, j, k] = b[h];
                int buff = b[h];
                b[h] = b[b.Length-1];
                b[b.Length-1] = buff;
                Array.Resize(ref b, b.Length - 1);
                Console.Write($"{a[i, j, k]}{(i, j, k)} ");
            }
        }
        Console.WriteLine();
    }
    return a;
}
int[] RandomShuffle(int[] a)
{
    for (int i=0; i <maxRandom;i++)
    {
        a[i] = i;
    }
    return a;
}