// напишу программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом первогою
int a = Convert.ToInt32(Console.ReadLine());//конверт строки в число
int b = Convert.ToInt32(Console.ReadLine());

if (a * a == b)
{
    Console.WriteLine(b + " квадрат " + a);
}
else   
    Console.WriteLine(b + " не квадрат " + a);