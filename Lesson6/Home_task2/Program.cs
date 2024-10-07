// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные. 
// “aBcD1ef!-” => “abcd1ef!-”

using System;
class Program
{
    static string GetLowerCaseString(string str)
    {
        string str1 = str.ToLower();
        return str1;
    }

    static void PrintString(string str)
    {
        Console.WriteLine(str);
    }

    static void Main()
    {
        Console.Write("Введите строку: ");
        string str = Convert.ToString(Console.ReadLine());
        Console.WriteLine();
        PrintString(GetLowerCaseString(str));
    }
}

