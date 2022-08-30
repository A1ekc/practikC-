// поиск в рандомном массиве заданного числа

Console.WriteLine("Введите число для проверки: ");
int number = Convert.ToInt32(Console.ReadLine());
int size = 10;
int [] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
Console.WriteLine();



for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == number)
    {
        Console.WriteLine("В массиве присутствует введённое вами число");
        break;
    }
    else if (i == numbers.Length -1)//для того чтобы запись выводилась один раз а не на каждое обращение к элементу
    {
        Console.WriteLine("В массиве  не присутствует введённое вами число");
    }
}


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
