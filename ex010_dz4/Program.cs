// Напишите программу, которая на вход принимает чилсо N, а на выходе показывает все чётные числа от 1 до N

Console.Write(" Введите чиcло N(получите числа от 1 до N ): ");
int a = Convert.ToInt32(Console.ReadLine());//конверт строки в число
int count = 0;
while (count < a)
{
    Console.WriteLine(count+ " ");
    count= count+2;
}




