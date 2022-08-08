// Написать программу, которая на вход принимает два числа и выдаёт, какое число больше, а какое меньше.
Console.Write(" Введите два числа(получите максимальное и минимальное): ");
int a = Convert.ToInt32(Console.ReadLine());//конверт строки в число
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine(a +  " максимальное число " + b + " минимальное" );
}
else
{
    Console.WriteLine(a +  " минимальное число " + b + " максимальное" );
}

