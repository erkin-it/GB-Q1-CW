﻿// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

bool CheckLenString (string Value)
{
    int LenStr = Value.Length;
    if (LenStr < 4) return true;
    else return false;
}

////////////////////////////////////////////////////

Console.WriteLine (CheckLenString("Text"));