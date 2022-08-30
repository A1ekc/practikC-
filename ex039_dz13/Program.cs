// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

int Readint(string messege)//метод
{
    Console.WriteLine(messege);
    return Convert.ToInt32(Console.ReadLine());
}

int size = Readint("Введите размерность массива: ");

int[] array = new int[size];

for (int i = 0; i < array.Length; i++)
    {
       array[i] = new Random().Next(0,100);
    }
PrintArray(array);

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
