// Задание 3: Транспонирование двумерного массива
// Описание: Задайте двумерный массив целых чисел. Напишите программу, которая транспонирует массив (меняет строки и столбцы местами).

// Пример входных данных:
// 1 2
// 3 4
// 5 6
// Пример результата:
// 1 3 5
// 2 4 6

using System;
class Program
{
    static void TransposeMatrix(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);
        int[,] transposed = new int[cols, rows];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                transposed[j, i] = array[i, j];
            }
        }
        PrintArray(transposed);
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
        int[,] array = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
        PrintArray(array);
        Console.WriteLine();
        TransposeMatrix(array);
    }
}

