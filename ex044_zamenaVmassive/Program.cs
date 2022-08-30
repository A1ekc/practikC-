// Программаземеняет элементы массива: положительные на отрицательные и наоборот


int size = 12;
int [] numbers = new int [size];// инициализация массива


FillArrayRandomNumbers(numbers);
PrintArray(numbers);
Console.WriteLine();
PrintInvertArray(numbers);


void PrintInvertArray (int[] array)
{
for (int i = 0; i < numbers.Length; i++)//считаем положительн и отрицат числа
{
   Console.Write(-array[i] + " "); 
}
Console.WriteLine();
}


void FillArrayRandomNumbers(int [] array)// рандом числа в массив
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
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

