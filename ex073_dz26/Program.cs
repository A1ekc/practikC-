// Напишите программу, которая заполнит спирально массив 4 на 4.


        //Заполним массив, количество строк мы обозначим m, а столбцов - n.
        int rows = 4;
        int colums = 4;
 
        //С помощью переменной s задаются числа внутри массива начиная с 1.
        int s = 1;
 
        //Объявляем и инициализируем массив.
        int[,] array = new int[rows, colums];
 
        //Заполняем периметр массива по часовой стрелке.
        for (int j = 0; j < colums; j++) 
        {
            array[0, j] = s;
            s++;
        }
        for (int i = 1; i < rows; i++) 
        {
            array[i, colums - 1] = s;
            s++;
        }
        for (int j = colums - 2; j >= 0; j--) 
        {
            array[rows - 1, j] = s;
            s++;
        }
        for (int i = rows - 2; i > 0; i--) 
        {
            array[i, 0] = s;
            s++;
        }
 
        //Периметр заполнен. Продолжаем заполнять массив и задаём
        //координаты ячейки, которую необходимо заполнить следующей.
        int c = 1;
        int d = 1;
 
        while (s < rows * colums) 
        {
            //Периметр мы заполнили числами, отличными от нулей.
            //Следующие циклы поочерёдно работают, заполняя ячейки.
            //Вложенный цикл останавливается, если следующая ячейка имеет 
            //значение, отличное от ноля. Ячейка, на которой остановился 
            //цикл, не заполняется.
 
            //Движемся вправо.
            while (array[c, d + 1] == 0) {
                array[c, d] = s;
                s++;
                d++;
            }
 
            //Движемся вниз.
            while (array[c + 1, d] == 0) {
                array[c, d] = s;
                s++;
                c++;
            }
 
            //Движемся влево.
            while (array[c, d - 1] == 0) {
                array[c, d] = s;
                s++;
                d--;
            }
 
            //Движемся вверх.
            while (array[c - 1, d] == 0) {
                array[c, d] = s;
                s++;
                c--;
            }
        }
 
        //При данном решении в центре всегда остаётся незаполненная ячейка.
        //Убираем её при помощи следующего цикла.
        for (int i = 0; i < rows; i++) 
        {
            for (int j = 0; j < colums; j++) 
            {
                if (array[i, j] == 0) 
                {
                    array[i, j] = s;
                }
            }
        }
 
        //Выводим массив в консоль.
        void PrintArray2D(int[,] array)
        {
            for (int i = 0; i < rows; i++) 
            {
                for (int j = 0; j < colums; j++) 
                {
                    if (array[i, j] < 10) 
                    {
                        //Два пробела, чтобы в консоли столбцы были ровные.
                        Console.Write(array[i, j] + ",  ");
                    } 
                    else 
                    {
                        Console.Write(array[i, j] + ", ");
                    }
                }
                Console.Write("");
            }
            Console.WriteLine();
        }

PrintArray2D(array);

/*
int rows = ReadInt("Введите количество строк: ");
int colums = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, colums];


PrintArray2D(numbers);
//тут должен быть цикл while (не придумать выход)
TopLeftToRight(numbers);
RightTopToDown(numbers);
DownRightToLeft(numbers);
LeftDownToTop(numbers);
TopLeftToRight(numbers);
RightTopToDown(numbers);
LeftDownToTop(numbers);

PrintArray2D(numbers);

int num = 1;

int I = 0;//смещение для следующего шага вправо
int TopLeftToRight (int[,] array)
{   
    while(numbers[i, j] = 0)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {   
            numbers[0+I,j] = num;//шаг для следующего шага вправо
            num++; 
        }
    }
    I++;
}
int J = 0;//смещение
int RightTopToDown (int[,] array)
{   
    while(numbers[i, j] = 0)
    {
        for (int i = 0; i < numbers.GetLength(0); i++)
        {   
            numbers[i, colums - J] = num;
            num++; 
        }
    }
    J++;
}
int K = 0;//смещение
int DownRightToLeft (int[,] array)
{   
    while(numbers[i, j] = 0)
    {
        for (int j = colums; j > 0; j--)
        {   
            numbers[rows - K, j] = num;
            num++; 
        }
    }
    K++;
}
int L = 0;//смещение
int LeftDownToTop (int[,] array)
{   
    while(numbers[i, j] = 0)
    {
        for (int i = rows; i > 0; i--)
        {   
            numbers[i, 0 + L] = num;
            num++; 
        }
    }
    L++;
}


void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)//GetLength(0) - строки
    {
        for (int j = 0; j < array.GetLength(1); j++)//GetLength(1) - столбцы
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/