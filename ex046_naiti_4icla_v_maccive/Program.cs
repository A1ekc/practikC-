// Задать одномерный массив и 123 случайных чисел. Найти количество элементов массива, значения которых лежат в отрезке [10,99]

int size = 10;
int [] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int result = 0;

for (int i = 0; i < numbers.Length; i++)
    {
        if ((numbers[i] > 9) & (numbers[i] < 100))
        {
            result++;
        }   
    }Console.WriteLine($"В массиве {result} символов");


void FillArrayRandomNumbers(int [] array)// рандом числа в массив
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 150);
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