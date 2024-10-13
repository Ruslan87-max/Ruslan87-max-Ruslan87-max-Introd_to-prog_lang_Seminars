// Задача 3: Вывод элементов массива в обратном порядке Описание: Задайте произвольный массив. Выведите его элементы, начиная с конца. Используйте рекурсию и не используйте циклы.

// Пример:
// ● Вход: {1, 2, 3, 4, 5}
// ● Выход: 5, 4, 3, 2, 1
// ● Вход: {10, 20, 30, 40}
// ● Выход: 40, 30, 20, 10

using System;
using System.Runtime.InteropServices;
public class Answer
{
    static int indexValue = 0;
    static string str = "";
    public static void PrintArrayReverse(int[] array, int index)
    {
        // Введите свое решение ниже
        if (index < 0)
        {
            string[] str2 = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(String.Join(", ", str2));
        }
        else
        {
            str = str.Insert(indexValue, Convert.ToString(array[index]) + ' ');
            indexValue = str.Length;
            PrintArrayReverse(array, --index);
        }
    }
    static public void Main(string[] args)
    {
        int[] array = { 10, 20, 30, 40 }; // Можно поменять значение для проверки
        Console.WriteLine("Массив в обратном порядке:");
        PrintArrayReverse(array, array.Length - 1);
    }
}
