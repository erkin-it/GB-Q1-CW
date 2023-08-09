// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Функция проверки строки на условие: длина строки меньше или равно 3 символам
bool CheckLenString (string Value)
{
    int LenStr = Value.Length;
    if (LenStr < 4) return true;
    else return false;
}

// Функция разбивки строки на массив строк по критерию ", "
string [] InitArrayString (string strValue)
{
    string [] strings= strValue.Split (", ");
    return  strings;
}

// Функция вывода массива строк на эркан: ["str1", "str2", ... "srtN"]
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

// Функция создание строки из массива строк с проверкой на длину строки элемента массива
string NewStringFromArray (string [] strings)
{
    string newValue = "";
    bool firstElement = true;
    foreach (string s in strings)
    {
        if (CheckLenString(s)) 
        {
            if (firstElement) 
            {
                newValue = s;
                firstElement = false;   
            }
            else newValue = newValue + ", " + s;
        }
    }
    return newValue;
}

 
/////////////////////////////////////////////////

//Формирование массива строк
string stringValue = "t1, test3, t333, t5"; 
string [] StringArray =  InitArrayString(stringValue);

//Вывод исходного массива на экран
PrintArrayString (StringArray);

Console.Write(" => ");

//Решение задачи: Формирование строки из массива строк отвечаюшие условию задачи
string newValue = NewStringFromArray(StringArray);

//Преобразование массива из строки
string [] newStringArray = InitArrayString(newValue);

//Вывод массива
PrintArrayString (newStringArray);