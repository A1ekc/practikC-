// Задать двумерный массив. Написать программу которая заменит строки на столбцы. В случае если это невозможно, 
//программа должна вывести сообщение для пользователя.

int rows = ReadInt("Введите количество строк: ");
int colums = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, colums];

FillArray2D(numbers);
PrintArray2D(numbers);

if (rows != colums)
{
    Console.Write("Это невозможно");
    return;
}
int[,] turnNumbers = new int[rows, colums];
for (int i = 0; i < numbers.GetLength(0); i++)//GetLength(0) - строки
{
    for(int j = 0; j < numbers.GetLength(1); j++)
    {
        turnNumbers[i, j] = numbers[j, i];
    }
}
//второй вариант через диагональ 
//for (int i = 0; i < numbers.GetLength(0); i++)//GetLength(0) - строки
//{
//   for(int j = 0; j < i; j++)
//    {
//        int temp = numbers[i, j];
//        numbers[i, j] = numbers[j, i];
//        numbers[j, i] = temp;
//    }
//}
PrintArray2D(turnNumbers);

void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)//GetLength(0) - строки
    {
        for (int j = 0; j < array.GetLength(1); j++)//GetLength(1) - столбцы
        {
            array[i, j] = new Random().Next(0, 5);
        }
    }
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)//GetLength(0) - строки
    {
        for (int j = 0; j < array.GetLength(1); j++)//GetLength(1) - столбцы
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
