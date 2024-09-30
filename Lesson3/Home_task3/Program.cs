/* 
Задание 3: Поиск среднего значения массива
Описание: Задайте массив из 10 целых чисел. Найдите среднее значение элементов
массива.
 */

using System;
using System.Linq;
class Program
{
    static double CalculateAverage(int[] numbers)
    {
        double sum = 0;                     
        foreach (double e in numbers)               /*Другое решение- в использовании метода Array.sum(): double sum = numbers.Sum();*/
        {
            sum += e;
        }
        return sum / numbers.Length;
    }
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // Пример массива
        double average = CalculateAverage(numbers);
        Console.WriteLine(average);
    }
}
