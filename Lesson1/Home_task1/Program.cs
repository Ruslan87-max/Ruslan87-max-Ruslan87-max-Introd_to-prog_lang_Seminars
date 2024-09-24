// Задание 1
// Определите, делится ли число на другое
// Описание: Напишите метод, который на вход принимает два целых числа и проверяет,
// делится ли первое число на второе. Если делится, выводите "делится", иначе
// выводите "не делится".

// Пример использования: На входе:
// ● firstNumber: 10
// ● secondNumber: 2

// На выходе:
// ● делится

// На входе:
// ● firstNumber: 10
// ● secondNumber: 3

// На выходе:
// ● не делится

using System;
public class Answer
{
    static void CheckDivisibility(int firstNumber, int secondNumber)
    {
        if ((firstNumber % secondNumber) != 1) {
            Console.WriteLine($"делится");
        }
        else {
            Console.WriteLine($"не делится");
        }
    }
    static public void Main(string[] args)
    {
        int firstNumber, secondNumber;
        if (args.Length >= 2)
        {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        }
        else
        {
            firstNumber = 10;
            secondNumber = 2;
        }
        CheckDivisibility(firstNumber, secondNumber);
    }
}
