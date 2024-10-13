// Задача 2: Функция Аккермана
// Описание: Напишите программу для вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.

// Пример:
// ● Вход: m = 2, n = 3
// ● Выход: A(m, n) = 29
// ● Вход: m = 1, n = 4
// ● Выход: A(m, n) = 7

using System;
public class Answer
{
    public static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else if (m > 0 && n > 0)
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
        else {
            return 0;
        }
    }
    static public void Main(string[] args)
    {
        int m = 3; // Можно поменять значение для проверки
        int n = 5; // Можно поменять значение для проверки
        int result = Ackermann(m, n);
        Console.WriteLine($"A({m}, {n}) = {result}");
    }
}