// Написать программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write(" Введите два числа(получите максимальное и минимальное): ");
int a = Convert.ToInt32(Console.ReadLine());//конверт строки в число
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());



if (a>b)
{
    if (a>c)
    {
        Console.WriteLine(a +  " максимальное число ");
    }
    else 
    {
        Console.WriteLine(c +  " максимальное число ");
    }
}
else
{
    if (b>c)
    {
        Console.WriteLine(b +  " максимальное число ");
    }
    else
     {
        Console.WriteLine(c +  " максимальное число ");
    }
}

/*if (a>b||a>c)
{
    Console.WriteLine(a +  " максимальное число ");
}
if (b>a||b>c)
{
    Console.WriteLine(b +  " максимальное число ");
}
if (c>a||c>b)
{
    Console.WriteLine(c +  " максимальное число ");
}*/