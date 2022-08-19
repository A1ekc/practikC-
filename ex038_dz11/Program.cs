// Цикл который принимает на вход два числа  (А.В) и возводит А в натуральную степень В
int result = 1;
int i = 0;

int Readint(string messege)//метод
{
    Console.WriteLine(messege);
    return Convert.ToInt32(Console.ReadLine());
}

int Number = Readint("Введите число: ");
int Stepen = Readint("Введите степень: ");


    while (i < Stepen)
    {
        result = result * Number;
        i++;
    }
    //return result;
Console.WriteLine(result);




