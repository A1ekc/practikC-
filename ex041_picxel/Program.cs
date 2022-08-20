// закрасить рисунок (палец вверх)

int[,] pic = new int[,]
{
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 1, 1, 1, 1, 1, 1, 1, 1, 0},
    {0, 1, 0, 0, 0, 0, 0, 0, 1, 0},
    {0, 1, 0, 0, 0, 0, 0, 0, 1, 0},
    {0, 1, 0, 0, 0, 0, 0, 0, 1, 0},
    {0, 1, 1, 1, 1, 1, 1, 1, 1, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
};

void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            //Console.Write($"{image[i, j]} ");
            if(image[i,j] == 0) Console.Write($" ");// если равен нулю то печатаем пробел
            else Console.Write($"+");
        }
        Console.WriteLine();
    }
}


void FillImage(int row, int col)//закрашивание с точки внутри рисунка
{
    if(pic[row, col] == 0)
    {
        pic[row, col] = 1;//если равн нулю то закрасить
        FillImage(row-1, col);// поднимаемся выше
        FillImage(row, col-1);//влево
        FillImage(row+1, col);//вниз
        FillImage(row, col+1);//вправо
    }
}

PrintImage(pic);//передаём массив с прямоугольником
FillImage(4, 4);//случайная точка
PrintImage(pic);//

