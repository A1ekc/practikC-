// работа с массивом

//int[] numbers = {5, 6, 7, 8 ,9 ,10};//инициализация массива
//PrintArray(numbers);
int[] numbersA = {1, 2, 3};
int[] numbersB = {10, 11, 12}; 

numbersB = numbersA;
numbersA[2] = 50;
PrintArray(numbersA);
PrintArray(numbersB);

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}



