// Работа с текстом . Заменить символы другими


// string s = "qwerty"
//             012
//s[3] // r

string text = "-Я думаю, -сказал, улыбаясь, -что, "
            + "ежели бы вас послали вместо нашего милого Винценгроде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;// инициализация пустой строки

    int length = text.Length;//показвает количество символов в строке
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result =  result + $"{newValue}";//если совало с старым значением то записать другое
        else result = result + $"{text[i]}";// или оставить
    }

    return result;
}

string newText = Replace(text, ' ', '|');//замена пробела на черту
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
