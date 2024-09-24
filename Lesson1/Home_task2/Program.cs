// Задание 2
// Поиск среднего из трех чисел
// Описание: Напишите метод, который принимает на вход три числа и возвращает
// среднее из этих чисел (то есть не самое большое и не самое маленькое).

// Пример использования: На входе:
// ● a: 5
// ● b: 3
// ● c: 8

// На выходе:
// ● 5

// На входе:
// ● a: 1
// ● b: 9
// ● c: 7

// На выходе:
// ● 7

using System;
public class Answer
{
    static int FindMedian(int a, int b, int c)
    {
        int average = (a + b +c) / 3;
        return average;
    }
    static public void Main(string[] args)
    {
        int a, b, c;
        if (args.Length >= 3)
        {
            a = int.Parse(args[0]);
            b = int.Parse(args[1]);
            c = int.Parse(args[2]);
        }
        else
        {
            a = 5;
            b = 3;
            c = 10;
        }
        int result = FindMedian(a, b, c);
        System.Console.WriteLine($"{result}");
    }
}