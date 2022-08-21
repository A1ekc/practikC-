// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний. Результат записать в новый массив
int size = ReadInt("Ввдите размерность массива: ");
int [] numbers = new int[size];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int[] pairs;//новый массив либо чётный либо нечётный
if (numbers.Length % 2 == 0)
{
    pairs = new int [numbers.Length / 2];//чётный
}
else
{
    pairs = new int [numbers.Length / 2 + 1];//нечётный
    pairs[pairs.Length - 1] = numbers[numbers.Length / 2];//число без пары в последний элемент массива(по умолчанию ноль)
}


for (int i = 0; i < numbers.Length / 2; i++)
    {
       pairs[i] = numbers[i] * numbers[numbers.Length -1 -i];
    }
PrintArray(pairs);



void FillArrayRandomNumbers(int [] array)// рандом числа в массив
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 5);
    }
}

void PrintArray(int[] array)//вывод массива на экран
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}