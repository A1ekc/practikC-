// Программа, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
/*int firstDigit = 0;
int xxNumber = 0;
int threeDigit = 0; 
*/

int randomNumber = GetRandomNumber(100,999);//случайное число в отрезке
Console.WriteLine(randomNumber);
Console.WriteLine(FirtsThreeDigit(randomNumber));

int GetRandomNumber( int min, int max)//создаём метод для выбора случайного числа
{
     return new Random().Next(min, max + 1);
}

int FirtsThreeDigit (int randomNumber) //поиск трёх чисел в трёхзначном числе
{
    int firstDigit = randomNumber /100;// первая цифра
    int threeDigit = randomNumber % 10;// третее число остаток от деления на 10 
    // второе число не находи так как по условию оно не нужно
    //return(firstDigit,threeDigit);
    return firstDigit * 10 + threeDigit;
}

