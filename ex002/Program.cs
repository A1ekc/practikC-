// напишу программу, которая на вход принимает число и выдаёт его квадрат.
Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());//конвертирует строку в число //ввод числа в строку
int sqrNumber = number * number;
Console.WriteLine(number + " в квадрате равно " + sqrNumber);
