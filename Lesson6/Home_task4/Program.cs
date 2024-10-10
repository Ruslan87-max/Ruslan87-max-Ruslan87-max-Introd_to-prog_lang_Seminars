// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку,в которой слова расположены в обратном порядке. Вполученной строке слова должны быть также разделены пробелами.
// Пример: “Hello my world” => “world my Hello”

using System;
using System.Text;
class Program
{
    static void ShowReversedStringWithSpases(string s)
    {
        int j = 0;
        char[] separators = new char[] { ' ', '.', ',', ';', ':', '?', '!', '-' };
        string[] subs = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        string[] str2 = new string[subs.GetLength(0)];

        for (int i = subs.GetLength(0) - 1; i >= 0; i--)
        {
            str2[j] = subs[i];
            j++;
        }
        
        Array.ForEach(str2, x => Console.Write(x + ' '));
        // Console.WriteLine(String.Join(' ', str2));
    }

    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");
        Console.Write("Введите строку, разделённую пробелами или символмаи: ");
        string str = Convert.ToString(Console.ReadLine());
        Console.Write($"Reversed sentence: ");
        ShowReversedStringWithSpases(str);
    }
}
