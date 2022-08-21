// Задать одномерный массив заполненный случайными числами. Наййти сумму элементов массива стоящих на нечётных позициях.

int size = ReadInt("Ввдите размерность массива: ");
int [] numbers = new int[size];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int result = 0;

for (int i = 0; i < numbers.Length; i++)
    {
        if (i % 2 != 0 )
        {
           result += numbers[i];
        }   
    }Console.WriteLine($"Сумма чисел стоящих на нечётных позициях = {result}");




void FillArrayRandomNumbers(int [] array)// рандом числа в массив
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
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

