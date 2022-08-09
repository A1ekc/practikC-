// Программа которая будет принимать на вход два числа и выводить, является ли первое число кратным второмую Если число 1 не кратно числу 2, то программа выводит остаток от деления.

//Console.WriteLine("Первое число: ");
//int firstNumber = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Второе число: ");
//int secondNumber = Convert.ToInt32(Console.ReadLine());
//меняем запись + добавляем метод

int firstNumber = Readint("Первое число: ");
int secondNumber = Readint("Второе число: ");

int remainderOfDivision = firstNumber % secondNumber; //остаток от деления
if (remainderOfDivision == 0)
{
    Console.WriteLine("Числа кратны");
}
else
{
    Console.WriteLine("Числа  не кратны, остаток от деления -" + remainderOfDivision);
}

int Readint(string message)//метод
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}