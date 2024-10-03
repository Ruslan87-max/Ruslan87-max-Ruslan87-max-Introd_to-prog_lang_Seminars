// Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;


class Program
{
    static int[] GetArray(int counter)
    {
        string s = "";
        int[] array = new int[counter];
        Random random = new Random();

        for (int i = 0; i < counter; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                s = s.Insert(j, Convert.ToString(random.Next(0, 9)));
            }
            array[i] = Convert.ToInt32(s);
            s = "";
        }
        return array;
    }
    static void Main()
    {
        Console.Write("n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] array= GetArray(n);

        Console.Write($"[" + String.Join(", ", array) + "]");

        int k = array.Where(x => x % 2 == 0).Count();
        Console.WriteLine($"\n{k}");
    }
}