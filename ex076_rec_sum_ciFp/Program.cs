// Программа которая принимает на вход два числа и возвращает сумму цифр

Console.Write("Введите любое число: ");
int n = int.Parse(Console.ReadLine());//1-123

int SumDigits(int n)//1-123
{
    if (n > 10)//  3 остаток          12и тд 
        return  n % 10 + SumDigits(n / 10);

    return n;//когда if не сработает то вернётся последннее число которое неподелилось на 10    

}

Console.WriteLine("Сумма цифр заданного числа равна: " + SumDigits(n));
