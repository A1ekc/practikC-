// Программа которая принимает на вход число N и выдаёт таблицу квадратов чисел от 1 до N.

int number = ReadInt("Введите число N: ");
int i =1;

while(i <= number)
{
    Console.Write(Sqr(i) + " ");
    i++;
}
int Sqr(int a)
{
    return a*a;
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}