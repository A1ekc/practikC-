// Написать программу, которая на вход принимает число и выдаёт, является ли число чётным(делится ли оно без остатка)

Console.Write(" Введите чимло(получите ответ чётное или нет): ");
int a = Convert.ToInt32(Console.ReadLine());//конверт строки в число

if  (a % 2 == 0)
{
    Console.WriteLine(a +  " чётное ");
}
else
{
    Console.WriteLine(a +  " нечётное ");
}