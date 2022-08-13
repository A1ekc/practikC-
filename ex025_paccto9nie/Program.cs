// Программа которая принимает на вход координаты двух точек и находит расстояние между ними в 2D

Console.WriteLine("Введите координаты x первой точки: ");
int x1 = InputToInt();
Console.WriteLine("Введите координаты y первой точки: ");
int y1 = InputToInt();

Console.WriteLine("Введите координаты x второй точки: ");
int x2 = InputToInt();
Console.WriteLine("Введите координаты y второй точки: ");
int y2 = InputToInt();

double lenght = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));//Math.Sqrt -корень
Console.WriteLine($"A({x1}, {y1}); B({x2}, {y2}) -> {lenght}");//$ - для подставки знаяения в {}
//Console.WriteLine("Длина отрезка: " + lenght);

int InputToInt()
{
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}
