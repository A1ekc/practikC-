
//Напишите программу вычисления функции Аккермана с помощью
//рекурсии. Даны два неотрицательных числа m и n.

int m = ReadInt("Введите число M: ");
int n = ReadInt("Введите число N: ");

int ReadInt(string message)
{
    Console.Write(message);
    return   Convert.ToInt32(Console.ReadLine());
}

///Метод вычисления функции Аккермана:
int AckermannFunction (int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return AckermannFunction(m - 1, 1);
    if (m > 0 && n > 0) return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
return AckermannFunction(m, n);
}

Console.WriteLine($"Функция Аккермана для чисел A({m},{n}) = {AckermannFunction(m, n)}");