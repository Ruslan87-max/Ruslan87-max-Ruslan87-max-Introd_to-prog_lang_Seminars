using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;


class Program
{
    static int GetSumOfDigitsIsNumber(string str)
    {
        int sum = 1;
        int[] array;
        bool isNumber = int.TryParse(str, out int result);

        if (isNumber)
        {
            array = str.ToCharArray().Select(i => int.Parse(i.ToString())).ToArray();
            sum = array.Sum();
        }
        return sum;
    }
    static void Main()
    {
        var s = "";

        while (true)
        {
            s = Console.ReadLine();
            char[] matchedItems = Array.FindAll(s.ToCharArray(), x => x == 'q');

            if ((GetSumOfDigitsIsNumber(s) % 2 == 0) || (matchedItems.Length == 1))
            {
                Environment.Exit(0);
            }
        }
    }
}