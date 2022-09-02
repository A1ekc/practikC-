// Задать две матрицы.Написать программу которая будеи находить произведение двух матриц


int rows1 = ReadInt("Введите количество строк 1 матрицы: ");
int colums1 = ReadInt("Введите количество 1 матрицы: ");
int[,] numbers1 = new int[rows1, colums1];

int rows2 = ReadInt("Введите количество строк 2 матрицы: ");
int colums2 = ReadInt("Введите количество столбцов 2 матрицы: ");
int[,] numbers2 = new int[rows2, colums2];


FillArray2D(numbers1);
PrintArray2D(numbers1);

FillArray2D(numbers2);
PrintArray2D(numbers2);


if(numbers1.GetLength(1) != numbers2.GetLength(0))
{
    Console.WriteLine("Матрицы нельзя перемножить");
}
    
    int[,] resultNumbers = new int[numbers1.GetLength(0), numbers2.GetLength(1)];
        for (int i = 0; i < numbers1.GetLength(0); i++)
        {
                for (int j = 0; j < numbers2.GetLength(0); j++)
                {
                    for (int k = 0; k < numbers2.GetLength(1); k++)
                    {
                        resultNumbers[i, k] += numbers1[i, j] * numbers2[j, k];
                    }
                }
        }
PrintArray2D(resultNumbers); 

            
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