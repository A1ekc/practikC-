// Задать значение N. Написать программу которая выведет все натуральные числа в промежутке от N до 1.

int number = ReadInt("Введите число: ");

int ReadInt(string message)
{
    Console.Write(message);
    return   Convert.ToInt32(Console.ReadLine());
}

NaturalNumber(number);

void NaturalNumber(int number)
{

    if (number > 1)
    {
        Console.Write($"{number}, ");
        NaturalNumber(number - 1);
    }

    if (number == 1)
    {
        Console.Write($"{number} ");
    }

}
