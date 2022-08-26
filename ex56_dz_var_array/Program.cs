 //  Пользователь вводит с клавиатуры числа через запятую. Посчитать, сколько чисел  больше 0 введено.(на английской раскладке) 


Console.WriteLine("Введите числа через запятую: ");
string input = Console.ReadLine();

int[] numbers = ParseStringToArray(input);




PrintArray(numbers);

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] ParseStringToArray(string input)
{
    int countNumbers = GetCountNumbersInString(input);
    int[] numbers = new int[countNumbers];
    int indexNumber = 0;
    string substring = string.Empty;//создаём переменную числа до запятой
    for(int i = 0; i < input.Length; i++)
    {
        if (input[i] != ',')
        {
            substring += input[i];
        }
        else 
        {
            numbers[indexNumber] = Convert.ToInt32(substring);
            indexNumber++;
            substring = string.Empty;//сброс значения
        }
    }
if (input[input.Length - 1] != ',')//проверка на запятую вконце
numbers[indexNumber] = Convert.ToInt32(substring);//записываю число в массив
return numbers;
}

int GetCountNumbersInString(string input)//подсчёт количества чисел
{   
    int count;
    if (input[input.Length - 1] == ',')//проверка на запятую вконце
        count = 0;
    else
        count = 1;

    for(int i = 0; i < input.Length; i++)
    {
        if(input[i] == ',')
        count++;
    }
    return count;
}