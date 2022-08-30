// Не используя рекурсию ввести первые N чисел фибоначи. Первые два числа 0 и 1

int size = ReadInt("Сколько чисел фибоначи вывести: ");
int first = 0;
int second = 1;
Console.Write($"{first} {second} ");

for ( int i = 2; i < size; i++)//size - numbersFibonacci.Length - массив
{
    int temp = second;// временная переменная
    second += first;
    first = temp;
    Console.Write(second + " ");
   // numbersFibonacci[i] = numbersFibonacci.Length[i - 1] + numbersFibonacci[i - 2];//вариант через массив
}
//PrintArray(numbersFibonacci);// через массив



int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
