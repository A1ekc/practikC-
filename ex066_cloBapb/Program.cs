// Составить частотный словарь элементов двумерного массива. Частотныц словарь словарь содержит информацию о том сколько раз встречается элемент входных данных.


int rows = ReadInt("Введите количество строк: ");
int colums = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, colums];

FillArray2D(numbers);
PrintArray2D(numbers);
SortArray(numbers);
PrintArray2D(numbers);

int countMatches = 1;
int temp = numbers[0, 0];//начинаем с первого элемента отсортированного массива

// узнаём сколько разнообразных элементов есть в массиве
for (int i = 0; i < numbers.GetLength(0); i++)//подсчёт количества в отсотированном массиве

    {
        for (int j = 0; j < numbers.GetLength(1); j++)//GetLength(1) - столбцы
        {
            if (temp != numbers[i, j])// если наталкиваемся на новый элемент 
            {
            temp = numbers[i, j];//присваиваем новый номер и увеличиваем счётчик
            countMatches++;
            }
        }
    }


// после того как узнали сколько различных элементов - создаём новый массив
int[,] frequencyDictionary = new int[2, countMatches];//создаём частотный словарь 1 строка элемент 2- сколько раз

int frequencyDictionaryIndex = 0;
frequencyDictionary[0, frequencyDictionaryIndex] = numbers[0, 0];//записываем первое число в двумерный массив
for (int i = 0; i < numbers.GetLength(0); i++)//подсчёт количества в отсотированном массиве

    {
        for (int j = 0; j < numbers.GetLength(1); j++)//GetLength(1) - столбцы
        {
            if (frequencyDictionary[0, frequencyDictionaryIndex] == numbers[i,j])//если число и
            {
                frequencyDictionary[1, frequencyDictionaryIndex]++;
            }
            else
            {
                frequencyDictionaryIndex++;// если нашли другое число то переходим на следующий индекс
                frequencyDictionary[0, frequencyDictionaryIndex] = numbers[i, j];//записываем в частотный словарь новое число
                frequencyDictionary[1, frequencyDictionaryIndex]++;
            }

        }
    }


for (int i = 0; i < frequencyDictionary.GetLength(1); i++)// выводим массив с цифрами и количеством их повторений

{
    Console.WriteLine($"Число {frequencyDictionary[0, i]} встречается {frequencyDictionary[1, i]} раз");
}


void SortArray(int[,] array)//сортирууем массив от максимума к минимуму//пузырьковая сортировка
{
    for (int i = 0; i < array.GetLength(0); i++)//GetLength(0) - строки
    {
        for (int j = 0; j < array.GetLength(1); j++)//GetLength(1) - столбцы
        {
            for ( int k = 0; k < array.GetLength(0); k++)
            {
                for ( int l = 0; l < array.GetLength(1); l++)
                {
                    if (array[k, l] < array[i, j])
                    {
                        int temp = array[i, j];
                        array[i, j] = array[k, l];
                        array[k, l] = temp;
                    }
                }
            }
        }
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

