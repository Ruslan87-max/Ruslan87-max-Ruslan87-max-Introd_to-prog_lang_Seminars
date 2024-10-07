// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

// Пример
// a b c => “abcdef”
// d e f 

using System;
class Program
{
    static void PrintArray(char[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }
    static string GetString(char[,] chars)
    {
        int i = 0;
        string str = "";
        foreach (char e in chars)
        {
            str = str.Insert(i, e.ToString());
            i ++;
        }
        return str;
    }

    static void PrintString (string str) {
        Console.WriteLine(str);
    }

    static void Main()
    {
        char[,] chars = {{'a', 'b', 'c'}, {'d', 'e', 'f'}};
        PrintArray(chars);
        Console.WriteLine();
        string str = GetString(chars);
        PrintString(str);
    }
}
