// Программа принимает два числа и возводит число в степень другого

Console.Write("Введите любое число: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Введите степень: ");
int power = int.Parse(Console.ReadLine());

int Power(int n, int pow)
{
    if (pow == 0)//если степень добралась до 0 то возвращаем 1. число в степени 0 =1
        return  1;
    
    return n * Power(n, pow - 1);//когда if не сработает то вернётся последннее число которое неподелилось на 10    

}

Console.WriteLine($"{number} ^ {power} = " + Power(number, power));

