// Задача 1: Вывод натуральных чисел в промежутке от M до N 
// Описание: Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Используйте рекурсию и не используйте циклы.

// Пример:
// ● Вход: M = 1, N = 5
// ● Выход: 1, 2, 3, 4, 5
// ● Вход: M = 4, N = 8
// ● Выход: 4, 5, 6, 7, 8

using System;
public class Answer
{
    public static void PrintRange(int M, int N)
    {
        if (M > N)
        {
            Console.WriteLine($"Достигнут верхний предел {N}");
            return;
        }
        else
        {
            Console.WriteLine($"{M ++}");
            PrintRange(M, N);
        }
    }
    static public void Main(string[] args)
    {
        int M = 10; // Можно поменять значение для проверки
        int N = 32; // Можно поменять значение для проверки
        Console.WriteLine("Числа в промежутке:");
        PrintRange(M, N);
    }
}
