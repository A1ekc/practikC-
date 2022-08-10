// Программа принимает на вход число и проверяет кратно ли оно одновременно 7 и 23

int number = ReadInt("Input number: ");
int firstDivider = 7;//делитель
int secondDivider = 23;//делитель

if (Multiple(number, firstDivider) && Multiple(number, secondDivider))
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}

bool Multiple(int a, int b)//метод
{
    return a % b == 0;
}
int ReadInt(string messege)//метод
{
    Console.WriteLine(messege);
    return Convert.ToInt32(Console.ReadLine());
}