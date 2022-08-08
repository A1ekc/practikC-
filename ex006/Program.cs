//программа принимает на вход трёхзначное число а на выход выводит три последние цифры
Console.Write(" Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 999 || number < 100)
{
    Console.WriteLine("Введено неверное число");
}
else
Console.WriteLine("Результат: "+number%10);