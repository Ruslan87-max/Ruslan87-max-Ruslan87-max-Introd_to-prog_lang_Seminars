// Задание 4
// Вывести нечетные числа
// Описание: Напишите метод, который на вход принимает число (number), а на выходе
// выводит все нечетные числа от 1 до number (включительно), после каждого числа
// должен быть знак пробела.
// Пример использования: На входе:
// ● number: 5
// На выходе:
// ● 1 3 5
// На входе:
// ● number: 8
// На выходе:
// ● 1 3 5 7
// Заготовка:

using System;
public class Answer
{
    static void PrintOddNumbers(int number)
    {
       for (int i = 1; i <= number; i ++) {
            if (i % 2 == 1) {
                Console.Write($"{i} ");
            }
       }
    }
    static public void Main(string[] args)
    {
        int number;
        if (args.Length >= 1)
        {
            number = int.Parse(args[0]);
        }
        else
        {
            number = 8;
        }
        PrintOddNumbers(number);
    }
}
