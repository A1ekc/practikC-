// задача для поиска заданного значения в ячейках массива

void FillArray(int[] collection)
{
    int length = collection.Length;// возвращает размер массива
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);// помещает поочередно в каждую ячейку массива случайное число от 1 до 10
        index++;
    }
}


void PrintArray(int[] col)

{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int Indexof(int[] collection, int find)//
{
    int count = collection.Length;//определяем количество элементов массива
    int index = 0;
    int position = -1;//ячейка для сохранения нужной позиции/  -1 для того чтобы отметить в консоли что элемента который ищем нет в массиве 

    while (index < count)
    {
        if(collection[index] == find)//поиск нужного элемента
        {
            position =index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];// создать новый массив в котором будет 10 элементов. По умолчанию заполняется нулями

FillArray(array); // заполнили массив
PrintArray(array);// распечатали массив
Console.WriteLine();//пустрая строчка для того чтобы быть уверенным что не является частью массива

int pos = Indexof(array, 5);//ищем 4 в массиве
Console.WriteLine(pos);

