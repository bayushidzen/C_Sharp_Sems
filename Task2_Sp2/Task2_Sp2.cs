Console.Write("Введите количество программистов: ");
int a = Convert.ToInt32(Console.ReadLine());
int i=1;
while (i<a)
{
    if (i < 100) 
    {
        if ((i > 10) && (i < 20)) Console.Write($"{i} программистов ");
        else if ((i % 10 == 2)||(i % 10 == 3)||(i % 10 == 4)) Console.Write($"{i} программиста ");
        else if (i % 10 == 1) Console.Write($"{i} программист ");
        else Console.Write($"{i} программистов ");
    }
    else
    {   
        if ((i > 110) && (i < 120)) Console.Write($"{i} программистов ");
        else if ((i % 10 == 2)||(i % 10 == 3)||(i % 10 == 4)) Console.Write($"{i} программиста ");
        else if (i % 10 == 1) Console.Write($"{i} программист ");
        else Console.Write($"{i} программистов ");
    }
    i++;
}