// Программа, которая принимает на вход трёхзначное число и на выход показывет вторую цифру этого числа.
int randomNumber = GetRandomNumber(100,999);//случайное число в отрезке
Console.WriteLine(randomNumber);
Console.WriteLine(SecondNumberOrRandomNumber(randomNumber));

int GetRandomNumber(int min, int max) //метод для выбора случайного числа
{
    return new Random().Next(min, max + 1);
}

int SecondNumberOrRandomNumber (int randomNumber)//поиск второго числа в трёхзначном числе
{
    int xxDigit = randomNumber / 10; //получаем первые 2 числа
    int SecondNumberOrRandomNumber = xxDigit % 10; //нужное число
    return SecondNumberOrRandomNumber;
}