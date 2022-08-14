// Программа которая принимает на вход пятизначное число и проверяет является ли оно полиндромом
//не работает

string polindrom = ReadInt("Введите число N: ");

if ((polindrom[1]==polindrom[5])&&(polindrom[2]==polindrom[4]))
{
    Console.WriteLine("Это полиндром ");
}
else
{
    Console.WriteLine("Это не полиндром ");
}

string ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToString(Console.ReadLine()); 
   
}
