// Программа принимает на вход два числа и проверяет является ли одно число квадратом дргугого

int Readint(string messege)//метод
{
    Console.WriteLine(messege);
    return Convert.ToInt32(Console.ReadLine());
}

bool IsitSqr(int a, int b)//method
{
    return (a * a == b);
}

int FirstNumber = Readint("Первое число: ");
int SecondNumber = Readint("Второе число: ");

if (IsitSqr(FirstNumber,SecondNumber)|| IsitSqr(SecondNumber,FirstNumber))
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}

