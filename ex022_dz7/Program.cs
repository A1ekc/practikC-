// Программа принимает на вход цифру обозначающую день недели и проверяет является ли этот день выходным

Console.Write("Введите число от 1 до 7(получите ответ выходной или нет) : ");
int number = Convert.ToInt32(Console.ReadLine());//конверт строки в число

if ((1 < number)& (number < 8))
{
    if (number > 5)
    {
        Console.WriteLine(number + " выходной");
    }
    else
    {
        Console.WriteLine(number + " будни");
    }
}
else
{
    Console.WriteLine(number + " неверное число");
}