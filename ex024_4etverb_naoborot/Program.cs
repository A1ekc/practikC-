// Программа которая по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти

Console.WriteLine("Введите четверть(от 1 до 4): ");
int quarter = Convert.ToInt32(Console.ReadLine());

switch(quarter)
{
    case 1:
        Console.WriteLine("x > 0 && y > 0");
        break;
    case 2:
        Console.WriteLine("x < 0 && y > 0");
        break;
    case 3:
        Console.WriteLine("x < 0 && y < 0");
        break;
    case 4:
        Console.WriteLine("x > 0 && y < 0");
        break;
    default:
        Console.WriteLine("Четверти нет");
        break;
}


