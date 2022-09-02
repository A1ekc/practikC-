// Задать прямоугольный двумерный массив. Написать программу которая будет находить строку с наименьшей суммой элементов.
int rows = ReadInt("Введите количество строк: ");
int colums = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, colums];

FillArray2D(numbers);
PrintArray2D(numbers);

int index = 0;
int minSum = 0;
void SumMinSum(int[,] array)
{
for (int i = 0; i < numbers.GetLength(0); i++)//GetLength(0) - строки
    {   
        int sum = 0;
        for (int j = 0; j < numbers.GetLength(1); j++)//GetLength(1) - столбцы
        {
            sum += numbers[i, j];   
        }
        
        if (i == 0)
        {
            minSum = sum;
        }
        else if (sum < minSum)
        {
            minSum = sum;
            index = i;
        }
        Console.WriteLine($" Сумма {i} строки равна {sum}");
    }
    Console.WriteLine();
    Console.WriteLine($" Минимальная cумма {index} строки равна {minSum}");
}  

SumMinSum(numbers);




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