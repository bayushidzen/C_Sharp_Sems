// Напишите программу: которая принимает на вход координаты двух точек и находит расстояние между ними
// в N-мерном пространстве. Сначала задается N с клавиатуры, потом задаются координаты точек
Console.Write($"Введите количество плоскоcтей пространства: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr1 = new int[n];
int[] arr2 = new int[n];

int[] FillArray(int[] a)
{
    for (int i=0; i <n; i++)
{
    Console.Write($"Введите значение координаты {i+1} : ");
    a[i] = Convert.ToInt32(Console.ReadLine());
}
    return a;
}
Console.WriteLine("Первая точка: ");
FillArray(arr1);
Console.WriteLine();
Console.WriteLine("Вторая точка: ");
FillArray(arr2);
double halhresult=0;
for (int i=0; i<n; i++)
{
    halhresult = halhresult + Math.Pow(arr2[i] - arr1[i], 2);
}
double result = Math.Sqrt(halhresult);
Console.Write($"Расстояние между точками: {result:f2}");
