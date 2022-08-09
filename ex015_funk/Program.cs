// Программа которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа

int randomNumber = GetRandomNumber(10,99);//случайное число в отрезке
Console.WriteLine(randomNumber);

int firstDigit =randomNumber /10;// первая цифра
int secondDigit = randomNumber % 10;//вторая цифра %-остаток от деления на 10


int maxDigit = Max(firstDigit, secondDigit);//вызываем метод и передаём ему два числа
Console.WriteLine(maxDigit);

int GetRandomNumber( int min, int max)//создаём метод для выбора случайного числа
{
     return new Random().Next(min, max + 1);
}

int Max(int a, int b)//метод для сравнения двух чисел
{
    int max =0;
    if (a > b)
    {
        max = a;
    }
    else
    {
        max = b;
    }
    return max;
}