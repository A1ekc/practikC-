// Программа которая принимает на вход число и выдаёт сумму цифр в числе


int Readint(string messege)//метод
{
    Console.WriteLine(messege);
    return Convert.ToInt32(Console.ReadLine());
}

int Number = Readint("Введите число: ");
int result = 0;


while (Number > 0)
{   result = result + Number % 10;
    Number = Number /10;
}
Console.WriteLine(result);


/*int result = 0;

string Readint(string messege)//метод
{
    Console.WriteLine(messege);
    return Convert.ToString(Console.ReadLine());
}

string chiclo = Readint("Введите число: ");

int length = chiclo.Length;//показвает количество символов в строке

    for (int i = 0; i < length; i++)
    {   
         int number = Convert.ToInt32(chiclo[i]);
         result = result + number;
    }

    return result;

    
    Console.WriteLine(result);
    */
