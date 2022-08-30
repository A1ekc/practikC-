// Двумерный массив лекция

/*
string[,] table = new string[2, 5]; // [,] указатель двумерности 2- строки 5 -столбцы
// String.Empty - инициализация
// table[0,0] table[0,1] table[0,2] table[0,3] table[0,4]
// table[1,0] table[1,1] table[1,2] table[1,3] table[1,4]
table[1, 2] = "слово";

for (int rows = 0; rows < 2; rows++)
{
    for( int colums = 0; colums < 5; colums++)
    {
        Console.WriteLine($"-{table[rows, colums]}-");
    }
}
*/

void PrintArray(int[,] matr)// метод для вывода на экран таблицы
{
    for(int i = 0; i < matr.GetLength(0); i++) // rows - i //colums - j //GetLength(0)- 3//GetLength(1)-4
    {
        for( int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1,10);
        }
    }
}

int[,] matrix = new int[3,4];//инициализация

PrintArray(matrix);// проверка нулей
FillArray(matrix);//подставка значений
Console.WriteLine();
PrintArray(matrix);//печать