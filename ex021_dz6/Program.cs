// Программа которая выводит третью цифру заданного числа или сообщает что третьей цифры нет

Console.Write("Введите число()получите третью цифру этого числа : ");
int number = Convert.ToInt32(Console.ReadLine());//конверт строки в число

if (number > 99)
{
    while (number>= 1000)
    {
        int newNumber = (number/10);
        number = newNumber;
    }
    Console.WriteLine("Третья цифра вашего числа " + number % 10);
}
else
{
    Console.WriteLine("Третьего числа нет");
}
