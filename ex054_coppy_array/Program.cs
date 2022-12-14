// Программа создаёт копию заданного массива с помощью поэлементного копирования
int size = ReadInt("Размерность массива: ");
int[] numbers = new int[size];//создали массив заполненный нулями с заданой размерностью
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int[] copyNumbers = CopyArray(numbers);
PrintArray(copyNumbers);


int[] CopyArray(int[] array)
{
    int[] newArray = new int [array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

