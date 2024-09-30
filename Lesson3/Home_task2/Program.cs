/* 
Задание 2: Замена элементов массива
Описание: Задайте массив из 10 элементов, заполненный числами от -10 до 10.
Замените отрицательные числа на их абсолютные значения, а положительные числа
на их отрицательные эквиваленты.
 */

using System;
class Program
{
    static void SwapSigns(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < 0)
            {
                numbers[i] = Math.Abs(numbers[i]);
            }
            else
            {
                numbers[i] = numbers[i] * -1;
            }
        }
    }
    static void Main(string[] args)
    {
        int[] numbers = { 1, -5, 6, -7, 3 }; // Пример массива
        SwapSigns(numbers);
        Console.WriteLine("[" + string.Join(", ", numbers) + "]");
    }
}
