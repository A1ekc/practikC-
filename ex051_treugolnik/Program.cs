// Написать программу которая принимаеттна вход три числа и проверяет, может ли существовать треугольник с такими сторонами

int ab = ReadInt("Ввдите длину отрезка ab: ");
int bc = ReadInt("Ввдите длину отрезка bc: ");
int ca = ReadInt("Ввдите длину отрезка ca: ");


if ((ab < bc + ca) & (bc < ab + ca) & (ca < ab + bc))
{
    Console.Write("Треугольник существует");
}
else
{
Console.Write("Треугольник  не существует");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}