// Программа на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание что такого элемента нет. Во вводе 1 цифра - номер строки 2- столбца. Цифры не более 9


//Некорректная работа 11 в строке воспринимает как 49 49 
//1 Вариант рабочий

int rows = ReadInt("Введите количество строк: ");
int colums = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, colums];
int idRows = ReadInt("Введите строку: ");
int idColums = ReadInt("Введите столбец: ");

FillArray2D(numbers);
PrintArray2D(numbers);

if ((idRows < rows)&(idColums < colums))
//if ((positionRowsInt <= rows)&(positionColumsInt <= colums))
{
    Console.WriteLine(numbers[idRows, idColums]);
}
else
{
    Console.WriteLine("Такого элемента нет");
}

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


////////////////
//2 вариант -  Некорректная работа символ 11 в строке воспринимает как 49 49 
/*
int rows = ReadInt("Введите количество строк: ");
int colums = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, colums];

Console.WriteLine("Введите позицию элемента от 00 до 99 : ");
string position = Console.ReadLine();

FillArray2D(numbers);
PrintArray2D(numbers);
int positionRowsInt = 0;
int positionColumsInt = 0;

positionRowsInt = Convert.ToInt32(position[0]);
positionColumsInt = Convert.ToInt32(position[1]);
Console.WriteLine(positionRowsInt);// проверка конвертации
Console.WriteLine(positionColumsInt);


if ((positionRowsInt < rows)&(positionColumsInt < colums))
{
    Console.WriteLine(numbers[positionRowsInt, positionColumsInt]);
}
else
{
    Console.WriteLine("Такого элемента нет");
}

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

*/
