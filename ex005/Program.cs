// Напишите программу, которая на вход принимает одно число N , а на выход показывает все целые числа в промежутке от -N до N

Console.Write(" Введите число N ( получите все числа от -N до N): ");
int number = Convert.ToInt32(Console.ReadLine());

int a = -number;
while (a < number)
{

    Console.WriteLine(a+ " ");
    a++;
}
