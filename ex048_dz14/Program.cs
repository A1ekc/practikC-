// Задать массив заполненный случайными положительными трёхзначными числами. Написать программу которая покажет количество чётных чисел в массиве.

int size = ReadInt("Ввдите размерность массива: ");
int [] numbers = new int[size];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int result = 0;

for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0 )
        {
            result++;
        }   
    }Console.WriteLine($"В массиве {result} чётных символов");




void FillArrayRandomNumbers(int [] array)// рандом числа в массив
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(99, 999);
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
