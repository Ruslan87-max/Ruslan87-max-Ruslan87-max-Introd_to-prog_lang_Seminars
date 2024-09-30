/* 
Задание 1: Поиск элемента в массиве
Описание: Задайте массив целых чисел. Напишите программу, которая проверяет,
присутствует ли заданное число в массиве. Программа должна вывести:
Присутствует / Не присутствует. 
*/

using System;
class Program
{
    static bool IsNumberPresent(int[] numbers, int numberToFind)
    {
        for ( int i = 0; i < numbers.Length; i ++) {
            if (numberToFind == numbers[i]) {
                return true;
            }
            else {
                continue;
            }                        
        }
        return false;
    }
    static void Main(string[] args)
    {
        int[] numbers = { 1, 3, 4, 19, 3 }; // Пример массива
        int numberToFind = 19; // Пример числа для поиска
        if (IsNumberPresent(numbers, numberToFind))
        {
            Console.WriteLine("Присутствует");
        }
        else
        {
            Console.WriteLine("Не присутствует");
        }
    }
}

