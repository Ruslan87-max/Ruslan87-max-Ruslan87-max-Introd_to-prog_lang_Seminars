// Задание 1: Поиск максимального элемента в каждой строке
// Описание: Задайте двумерный массив целых чисел. Напишите программу, которая находит максимальный элемент в каждой строке массива и выводит его.

// Пример входных данных:
// 1 3 5 7
// 2 4 6 8
// 9 10 11 12

// Пример результата:
// Максимальный элемент в строке 0: 7
// Максимальный элемент в строке 1: 8
// Максимальный элемент в строке 2: 12


using System;
class Program
{
    static void FindMaxInRows(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);
        int max = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (array[i, j] > max)
                {
                    max = array[i, j];
                }
            }
            Console.WriteLine($"Максимальный элемент в строке {i}: {max}");
        }
    }

    static void PrintArray(int[,] array)
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
    static void Main()
    {
        int[,] array = { { 1, 3, 5, 7 }, { 2, 4, 6, 8 }, { 9, 10, 11, 12 } };
        PrintArray(array);
        Console.WriteLine();
        FindMaxInRows(array);
    }
}