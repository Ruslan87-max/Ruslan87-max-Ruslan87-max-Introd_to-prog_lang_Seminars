// Задание 4: Замена отрицательных элементов в двумерном массиве
// Описание: Задайте двумерный массив. Замените все отрицательные числа на их абсолютные значения.

// Пример входных данных:
// 1 -2 3
// -4 5 -6
// 7 -8 9

// Пример результата:
// 1 2 3
// 4 5 6
// 7 8 9

using System;
class Program
{
    static void ReplaceNegativeNumbers(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);
        
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] < 0) {
                    array[i, j] = Math.Abs(array[i, j]);
                }
            }
        }

        PrintArray(array);
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
        int[,] array = { { 1, -2, 3 }, { -4, 5, -6 }, { 7, -8, 9 } };
        PrintArray(array);
        Console.WriteLine();
        ReplaceNegativeNumbers(array);
    }
}
