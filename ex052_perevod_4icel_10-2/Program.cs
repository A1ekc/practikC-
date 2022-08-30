// Программма которая будет переволить десятичное число в двоичное
/* 1 Var

int number = ReadInt("Ввдите число: ");
int baseNumber = 2;// основание
string result = string.Empty;//string.Empty пустая строка

while(number > 0)
{
    result =  number % baseNumber + result;//приклееваем к строке результат
    number /= baseNumber;
}
Console.WriteLine(result);


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/

//2 Var

int inputNumber = ReadInt("Ввдите число: ");
int baseNumber = 2;// основание
int number = inputNumber;
int size = 0;
while(number > 0)//определяем размер массива
{
    size++;
    number /= baseNumber;
}
int[] result = new int[size];//передаём размер массива
number = inputNumber;// Обновляем переменную

for(int i = 0; i < result.Length; i++)
{
    result[result.Length - 1 -i] = number % baseNumber;//пишем с конца 
    number /= baseNumber;
}
PrintArray(result);


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}