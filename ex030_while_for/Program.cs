// Примеры с лекции 

//не принимают и не возврашают

void Method1()
{
    Console.WriteLine("Автор...");
}

//Method1();

//принимают но не возвращают

void Method2 (string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");

/////
void Method21 (string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

Method21(msg: "Текст", count: 4);//4 раза


//не принимают но возврщают

int Method3()
{
    return DateTime.Now.Year;
}
int yesr = Method3();
Console.WriteLine(year);

//принимают и возвращают

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result +text;
        i++;
    }
    return result;

}

sting res = Method4(10, "asdf");
Console.WriteLine(res);

/////////////////////////////////////////////////////////////
/////////////////FOR/////////////////////////////////////////

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result +text;
    }
    return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res);


//цикл в цикле (таблица умножения)

for (int i = 2; i <= 10; i++)
{
    for (int j = 0; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}