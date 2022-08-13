// программа, которая принимает на вход координаты точки x y , x !=0 , y !=0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int x = ReadInt("Введите x: ");
int y = ReadInt("Введите y: ");

if(x == 0 || y == 0)
{
   Console.Write("Номер четверти отпределить не удалось"); 
   return;//чтобы не использовать else  дальще
}

if (x > 0 && y > 0)
{
    Console.WriteLine("точка в 1 четверти");
}

if (x < 0 && y > 0)
{
    Console.WriteLine("точка во 2 четверти");
}

if (x > 0 && y < 0)
{
    Console.WriteLine("точка в 3 четверти");
}
if (x < 0 && y > 0)
{
    Console.WriteLine("точка в 4 четверти");
}



int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}