// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D

Console.WriteLine("Введите координаты x точки А: ");
int x1 = InputToInt();
Console.WriteLine("Введите координаты y точки A: ");
int y1 = InputToInt();
Console.WriteLine("Введите координаты z точки A: ");
int z1 = InputToInt();

Console.WriteLine("Введите координаты x точки B: ");
int x2 = InputToInt();
Console.WriteLine("Введите координаты y точки B: ");
int y2 = InputToInt();
Console.WriteLine("Введите координаты z точки B: ");
int z2 = InputToInt();

double lenght = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));//Math.Sqrt -корень
Console.WriteLine($"A({x1}, {y1}, {z1}); B({x2}, {y2}, {z2}) -> {lenght}");//$ - для подставки знаяения в {}
//Console.WriteLine("Длина отрезка: " + lenght);

int InputToInt()
{
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}
