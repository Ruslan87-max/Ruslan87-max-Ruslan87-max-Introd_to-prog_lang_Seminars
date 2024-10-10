// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

// Пример:
// “aBcD1ef!-” => Нет
// “шалаш” => Да
// “55655” => Да

using System;
using System.Text;
class Program
{
    static void DefineIsPalindromOrNot(string str)
    {

        int j = 0;
        string str2 = "";
        char[] chars = str.ToCharArray();
        for (int i = str.Length - 1; i >= 0; i--)
        {
            str2 = str2.Insert(j, chars[i].ToString());
            j++;
        }

        string s = str.SequenceEqual(str2) ? "Да" : "Нет";
        Console.WriteLine(s);
    }
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");
        Console.Write("Введите строку: ");
        string str = Convert.ToString(Console.ReadLine());
        // byte[] tmp = Encoding.Unicode.GetBytes(str); 
        // Array.ForEach(tmp, x => Console.Write(x + ", "));

        Console.WriteLine();
        Console.Write("Введенная строка палидром??? ");
        DefineIsPalindromOrNot(str);
    }

}


