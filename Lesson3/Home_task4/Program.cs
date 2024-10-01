﻿/* 
Задание 4: Удаление всех отрицательных чисел
Описание: Задайте массив целых чисел. Напишите программу, которая удаляет все
отрицательные числа из массива и возвращает новый массив, содержащий только
неотрицательные числа.
 */
using System;
using System.Linq;
class Program
{
    static int[] RemoveNegatives(int[] numbers)
    {
        /* int[] newArr = Array.FindAll(numbers, x => x >= 0);
        return newArr; */
        int[] newArr = new int[numbers.Length];
        int i = 0, newSize = numbers.Length;

        foreach (int e in numbers)
        {
            if (e >= 0)
            {
                newArr[i] = e;
                Array.Resize(ref newArr, newSize--);
                i++;
            }
        }
        return newArr;
    }
    static void Main(string[] args)
    {
        int[] numbers = { 5, -3, 9, -1, 2, -7, 0 }; // Пример массива
        int[] result = RemoveNegatives(numbers);
        Console.WriteLine("[" + string.Join(", ", result) + "]");
    }
}
