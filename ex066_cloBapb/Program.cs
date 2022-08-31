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

for (int i = 0; i < numbers.GetLength(0); i++)//считаем сколько разных цыфр в массиве
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

int[,] frequencyDictionary = new int[2, countMatches];//создаём частотный словарь зная сколько чисел имеем

int frequencyDictionaryIndex = 0;
frequencyDictionary[0, frequencyDictionaryIndex] = numbers[0, 0];// присваеваем нулевому индексу словаря первое значение
for (int i = 0; i < numbers.GetLength(0); i++)//подсчёт количества повторений
    {
        for (int j = 0; j < numbers.GetLength(1); j++)//GetLength(1) - столбцы
        {
            if (frequencyDictionary[0, frequencyDictionaryIndex] == numbers[i,j])//считаем количество повторений
            {
                frequencyDictionary[1, frequencyDictionaryIndex]++;
            }
            else
            {
                frequencyDictionaryIndex++;// если нашли другое число то сразу прибовляем +1
                frequencyDictionary[0, frequencyDictionaryIndex] = numbers[i, j];
                frequencyDictionary[1, frequencyDictionaryIndex]++;
            }

        }
    }

for (int i = 0; i < frequencyDictionary.GetLength(1); i++)// выводим массив с цифрами и количеством их повторений
{
    Console.WriteLine($"Число{frequencyDictionary[0, i]} встречается {frequencyDictionary[1, i]} раз");
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

