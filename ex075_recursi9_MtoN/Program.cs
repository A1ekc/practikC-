// Задать значения M и N Написать программу которая выведет все натуральные числа в промежутке от M до N
/*
int NaturalRange (int min, int max)
{
    if (max == min)
        return min;
    else
    {
        //max--;
        Console.Write($"{NaturalRange(min, max-1)} ");
    }
    return max;
}

int ReadInt(string message)
{
    Console.Write(message);
    return   Convert.ToInt32(Console.ReadLine());
}

int m = ReadInt("Введите минимальное значение: ");
int n = ReadInt("Введите максимальное значение: ");

Console.Write(NaturalRange(m,n) + " ");

*/
//если ввели номера не так
/*
int NaturalRange (int min, int max)
{   
    if(min > max)
    {
        int temp = max;
        max = min;
        min = temp;
    }
    if  (max == min)
        return min;
    else
    {
        //max--;
        Console.Write($"{NaturalRange(min, max-1)} ");
    }
    return max;
}

int ReadInt(string message)
{
    Console.Write(message);
    return   Convert.ToInt32(Console.ReadLine());
}

int m = ReadInt("Введите минимальное значение: ");
int n = ReadInt("Введите максимальное значение: ");

Console.Write(NaturalRange(m,n) + " ");

*/

//вариант преподователя

int m = ReadInt("Введите минимальное значение: ");
int n = ReadInt("Введите максимальное значение: ");

int ReadInt(string message)
{
    Console.Write(message);
    return   Convert.ToInt32(Console.ReadLine());
}

NaturalNumber(m, n);

void NaturalNumber(int m, int n)
{
    if (m < n)
    {
        Console.Write($"{m}, ");//сначала печатаем m
        NaturalNumber(m + 1, n);//потом вызываем опять и передаём m+1
    }

    if (m > n)
    {
        Console.Write($"{m}, ");
        NaturalNumber(m - 1, n);
    }

    if (m == n)
    {
        Console.Write($"{m} ");
    }

}