// Принимает на вход число N и выдаёт произведение чисел от 1 до N

int a = ReadInt("Введите число N: ");
int result = 1;


for (int i = 1; i <= a; i++)
{
    result *= i;//result = result * i;
}
Console.WriteLine($"{result}");


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()); 
}

