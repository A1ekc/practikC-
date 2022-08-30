// вычислим факториал 5! = 5*4*3*2*1 рекурсией 5! = 5* 4! и тд
/*
double Factorial (int n) 
{
    // 1! = 1
    // 0! = 1
    if(n == 1) return 1;
    else return n * Factorial(n - 1);
}
Console.WriteLine(Factorial(3));//подставляем факториал 3

for (int i = 1; i < 40; i++)//нагружаем проц расчётами 40 факториалов
{
     Console.WriteLine($"{i}! = {Factorial(i)}");
}
*/

// вывод чисел фибоначи 
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

double Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}


for (int i = 1; i < 50; i++)//50 чисел фибоначи
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
} 