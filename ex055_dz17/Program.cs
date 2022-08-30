// Пользователь вводит с клавиатуры числа через запятую. Посчитать, сколько чисел  больше 0 введено.(на английской раскладке) 

string massiv = Readint("Введите числa через запятую: ");
string number = string.Empty;//пустая строка
int numberint = 0;//
int count = 0;//для подсчёта количества
int length = massiv.Length;//показвает количество символов в строке


    for (int i = 0; i < length; i++)
    {
        if (massiv[i] != ',')//склеиваем число до запятой
        {
        number += massiv[i];
        }
        else
        {
        numberint = Convert.ToInt32(number);
        //Console.WriteLine($"{number}");//проверить какие числа выбирает

        //Console.WriteLine(numberint);//проверить какие числа выбирает

          if (numberint > 0)
          {
            count++;
            //number = string.Empty;//обнуляю строку
          }
             number = string.Empty;//обнуляю строку
        }
    }
        
Console.WriteLine(count);

string Readint(string messege)//метод
{
    Console.WriteLine(messege);
    return Convert.ToString(Console.ReadLine());
}