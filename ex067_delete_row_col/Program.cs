// Найти минимальный элемент в двумерном массиве и удалить строку и столбец где находится этот элемент.



int rows = ReadInt("Введите количество строк: ");
int colums = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, colums];
FillArray2D(numbers);
PrintArray2D(numbers);

int minIndexI = 0;
int minIndexJ = 0;

// поиск индекса минимального числа
for (int i = 0; i < numbers.GetLength(0); i++)//GetLength(0) - строки
    {
        for (int j = 0; j < numbers.GetLength(1); j++)//GetLength(1) - столбцы
        {
            if(numbers[minIndexI, minIndexJ] > numbers[i, j])
            {
                minIndexI = i;
                minIndexJ = j;
            }
        }
    }
   // Console.WriteLine($"{minIndexI} - {minIndexJ}"); //проверка правильности нахождения
   //создаём новый массив меньше на 1 столбец и 1 строку
int[,] newNumbers = new int[numbers.GetLength(0) - 1, numbers.GetLength(1) - 1];
//вводим две доп переменные
int shiftI = 0;
int shiftJ = 0;
//проходим циклом по новому массиву
for(int i = 0; i < newNumbers.GetLength(0); i++)
{
    for (int j = 0; j < newNumbers.GetLength(1); j++)
    {  //проскакиваем индексы с минимальным числом

        if(i >= minIndexI)
        {
            shiftI = 1;
        }
        else
        {
            shiftI = 0;
        }

        if(j >= minIndexJ)
        {
            shiftJ = 1;
        }
        else
        {
            shiftJ = 0;
        }
        newNumbers[i, j] = numbers[i + shiftI, j + shiftJ];
    }
}

PrintArray2D(newNumbers);

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