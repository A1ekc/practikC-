// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int m = ReadInt("Введите минимальное значение: ");
int n = ReadInt("Введите максимальное значение: ");

int ReadInt(string message)
{
    Console.Write(message);
    return   Convert.ToInt32(Console.ReadLine());
}


///Метод нахождения суммы натуральных элементов в промежутке от M до N
void ResultMN (int m, int n, int sum)
{
    if (m > n) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (m++);
    ResultMN(m, n, sum);
}

ResultMN(m, n, 0);

/*
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
         return sum;
        NaturalNumber(m + 1, n);//потом вызываем опять и передаём m+1
    }

    if (m > n)
    {
        sum += m;
        return sum;
        NaturalNumber(m - 1, n);
    }

    //if (m == n)
    //{
    //    sum = 0;
    //    Console.Write($"{0} ");
    //}
return sum;
}
Console.Write($"{sum}, ");
//Console.WriteLine("Сумма чисел равна: " + NaturalNumber(sum));
*/

