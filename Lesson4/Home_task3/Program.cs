// Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)^
// [1 3 5 6 7 8] => [8 7 6 5 3 1]

using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;


class Program
{
    static int[] GetArray(int length)
    {
        int[] array = new int[length];
        Random random = new Random();
        for (int i = 0; i < length; i++)
        {
            array[i] = random.Next(0, 9);
        }
        return array;
    }

    static int[] GetSortedArray(int[] array)
    {
        int i = 0, temp = 0;
        if (array.Length % 2 == 0)
        {
            do
            {
                temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
                i++;
            } while (2 * i != array.Length);
        }
        else
        {
            do
            {
                temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
                i++;
            } while (array.Length - 2 * i != 1);
        }

        return array;
    }

    static void PrintArray(int[] array)
    {
        Console.Write($"[" + String.Join(", ", array) + "]");
    }

    static void Main()
    {
        Console.Write($"Введите размерность массива: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int[] array = GetArray(num);
        PrintArray(array);
        Console.WriteLine($"\n");
        PrintArray(GetSortedArray(array));
    }
}