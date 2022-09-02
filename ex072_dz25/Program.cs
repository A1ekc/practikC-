// Создать трёхмерный массив из неповторяющихся двухзначных чисел.
//Написать программу которая построчно будет выводить массив
// и добавлять индекс каждого элемента

int mass = ReadInt("Введите количество массивов: ");
int rows = ReadInt("Введите количество строк: ");
int colums = ReadInt("Введите количество столбцов: ");
int[,,] numbers = new int[mass, rows, colums];

FillArray3D(numbers);
PrintArray3D(numbers);

//int GenerateRundomNumber()
//{
    //while (true)
    //{
        //int number = new Random().Next(9, 100);
        //if (!numbers.Contains(number))
        //{
        //    numbers.Add(number);
        //    return number;
        //}
    //}
//}


void FillArray3D(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)//GetLength(0) - строки
    {
        for (int j = 0; j < array.GetLength(1); j++)//GetLength(1) - столбцы
        {
           for (int k = 0; k < array.GetLength(2); k++)
            {   
                array[i, j, k] = new Random().Next(9, 100);//GenerateRundomNumber()
            }
        }
    }
}

void PrintArray3D(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)//GetLength(0) - строки
    {
        for (int j = 0; j < array.GetLength(1); j++)//GetLength(1) - столбцы
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {   
                Console.WriteLine(array[i, j, k]);
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}    

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


