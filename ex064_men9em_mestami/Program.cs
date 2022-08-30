// Двумерный массив. Программа меняет первую и последнюю строку массива

int rows = ReadInt("Введите количество строк: ");
int colums = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, colums];

FillArray2D(numbers);
PrintArray2D(numbers);
InversFillArray2D(numbers);
PrintArray2D(numbers);

void InversFillArray2D(int[,] array){
for (int j = 0; j < array.GetLength(1); j++)//GetLength(0) - строки
    {
        int temp = numbers[0,j];//временная переменная
        numbers[0,j] = numbers[numbers.GetLength(0)-1, j];
        numbers[numbers.GetLength(0)-1, j] = temp;
    }
}
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