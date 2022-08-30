// Программа которая принимает на вход пятизначное число и проверяет является ли оно полиндромом
//не работает

string polindrom = ReadInt("Введите число N: ");

if ((polindrom[0]==polindrom[4])&&(polindrom[1]==polindrom[3]))
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
