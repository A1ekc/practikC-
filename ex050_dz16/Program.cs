// Задать массив вещественных чисел. Найти разницу между максимальным и минимальным элементом.

int size = ReadInt("Ввдите размерность массива: ");
int [] numbers = new int[size];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int max = numbers[0];
int min = numbers[0];

for (int i = 0; i < numbers.Length; i++)
    {
       if (numbers[i] > max)
       {
            max = numbers[i];
       } 
       else if (numbers[i] < min)
       {
        min = numbers[i];
       }
    }Console.WriteLine($"Максимальное число = {max}");
     Console.WriteLine($"Минимальное число = {min}");
     Console.WriteLine($"Max - min =  {max - min}");




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


