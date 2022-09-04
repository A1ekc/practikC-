// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int m = ReadInt("Введите минимальное значение: ");
int n = ReadInt("Введите максимальное значение: ");

int ReadInt(string message)
{
    Console.Write(message);
    return   Convert.ToInt32(Console.ReadLine());
}

NaturalNumber(m, n);

int NaturalNumber(int m, int n)
{
    int sum = 0;
    if (m < n)
    {   
         sum += m;
        NaturalNumber(m + 1, n);//потом вызываем опять и передаём m+1
    }

    if (m > n)
    {
        sum += m;
        NaturalNumber(m - 1, n);
    }

    if (m == n)
    {
        sum = 0;
        Console.Write($"{0} ");
    }
return sum;

}
//Console.Write($"{sum}, ");
//Console.WriteLine("Сумма чисел равна: " + NaturalNumber(sum));

int sumTo(int n)
{
    if(n == 1)
        return 1;
    return n + sumTo(n-1);
}