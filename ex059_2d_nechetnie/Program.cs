// Задать двумерный массив. Найти элементы у которых оба индекса нечётные, и заменить эти элементы на их квадраты.

int rows = ReadInt("Введите количество строк: ");
int colums = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, colums];


FillArray2D(numbers);
PrintArray2D(numbers);

//for (int i = 0; i < numbers.GetLength(0); i++)
//{
//    for (int j = 0; j < numbers.GetLength(1); j++)
//    {
//        if (i % 2 != 0 && j % 2 != 0)
//        numbers[i, j] *= numbers[i,j];
//    }
//}
//Оптимизация
for (int i = 1; i < numbers.GetLength(0); i+=2)
{
    for (int j = 1; j < numbers.GetLength(1); j+=2)
    {
        numbers[i, j] *= numbers[i,j];
    }
}
Console.WriteLine();
PrintArray2D(numbers);

void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)//GetLength(0) - строки
    {
        for (int j = 0; j < array.GetLength(1); j++)//GetLength(1) - столбцы
        {
            array[i, j] = i + j;
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



