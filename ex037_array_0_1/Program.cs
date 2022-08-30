// Создать массив из 8 элементов с числами 1 и 0

int size = 8;
int[] array = new int[size];

for (int i = 0; i < array.Length; i++)
    {
       array[i] = new Random().Next(0,2);
    }
PrintArray(array);

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}




