// Программа принимает на вход число А и выдаёт сумму чисел от 1 до А

int a = ReadInt("Введите число N: ");
int sum = 0;


for (int i = 1; i <= a; i++)
{
    sum += i;//sum = sum + i;
}
Console.WriteLine($"{sum}");


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()); 
}
