//Поиск элемента в массиве

int[] array = {1, 12, 31, 4, 15, 4, 17, 18};

int n = array.Length;// возвращает количество элементов массива
int find = 4;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;//для остановки поиска тк может быть несколько одинаковых элемента
    }
    index++;
    
}
