// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

Console.Write("Введите число в диапазоне [10, 99]: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 10 && num <= 99)
{
    int num2 = num / 10;
    double num3 = Math.Round(((double)num / 10 - num2) * 10);
    // double num4 = Math.Round(num3);

    if (num2 == num3)
    {
        Console.Write($"Обе цифры числа {num} равны");
    }
    else if (num2 > num3)
    {
        Console.Write($"У числа {num} наибольшая из цифр={num2}");
    }
    else
    {
        Console.Write($"У числа {num} наибольшая из цифр={num3}");
    }
}
else {
    Console.Write($"Число {num} вне диапазона [10, 99]");
}