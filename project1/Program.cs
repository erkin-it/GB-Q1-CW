// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

bool CheckLenString (string Value)
{
    int LenStr = Value.Length;
    if (LenStr < 4) return true;
    else return false;
}

// Модуль приглашения для ввода данных в виде текста с клавиатуры

string InputString (string strValue)
{
    Console.Write (strValue);
    return Console.ReadLine();
}

string [] InitArrayString (string strValue)
{
    string [] strings= strValue.Split (", ");
    return  strings;
}

void PrintArrayString (string [] strings)
{
    Console.Write("[");
    bool firstElement = true;
    foreach (string s in strings)
    {
        if (firstElement) firstElement = false;
        else Console.Write (", ");
        Console.Write ($"\"{s}\"");
    }
    Console.Write ("]");
}

 
/////////////////////////////////////////////////

//string stringValue = InputString("Введите текст массива через запятую: ");
string stringValue = "test1, test3, t3, t5"; 
string [] oldString =  InitArrayString(stringValue);
PrintArrayString (oldString);
Console.WriteLine();