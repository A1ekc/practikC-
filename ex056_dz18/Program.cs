// Написать программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1,k1,b2,k2 задоются пользователем.
//формула правильная, считает некорректно

int b1 = ReadInt("Введите b1: ");
int b2 = ReadInt("Введите b2: ");
int k1 = ReadInt("Введите k1: ");
int k2 = ReadInt("Введите k2: ");


int first = (b1 - b2) / (k2 - k1);//из првого уравнения вычитаем второе


int second = (k2 * first) + b2;// во второе уравение помещаем значение первого


Console.WriteLine($"({first},{second})");


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}