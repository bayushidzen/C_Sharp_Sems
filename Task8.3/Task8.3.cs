// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// 2*3 + 4*3 | 2*4 + 4*3
// 3*3 + 2*3 | 3*4 + 2*3
int row = 3; //new Random().Next(3,10);
int col = 3; //new Random().Next(3,10);
int[,] arrA = new int[row, col];
int[,] arrB = new int[col, row];
int[,] arrC = new int[row, row];
Console.WriteLine("Первая матрица");
FillArray(arrA);
Console.WriteLine("Вторая матрица");
FillArray(arrB);
MultyArray(arrA, arrB);
Console.WriteLine("Результирующая матрица");
PrintArray2(arrC);

int[,] MultyArray(int[,] a, int[,] b)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < a.GetLength(1); k++)
            {
                sum += a[i,k] * b[k,j];
            }
            arrC[i,j] = sum;
        }
    }
    return a;
}

int[,] FillArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = new Random().Next(0, 100);
            Console.Write($"{a[i, j]} ");
        }
        Console.WriteLine();
    }
    return a;
}
void PrintArray2(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write($"{a[i, j]} ");
        }
        Console.WriteLine();
    }
}