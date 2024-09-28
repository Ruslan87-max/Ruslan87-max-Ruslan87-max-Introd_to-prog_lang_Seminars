// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
// Например, 568 => 5,6,8

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int i = 1;
int num4 = num;
double num2, num3 = 0;

while (num4 >= 10)
{
    num4 /= 10;
    i *= 10;
}
// Console.WriteLine($"{i}");

if ((double)num / i == num / i)
{
    Console.Write($"{num / i}");
    for (int j = i; j != 1; j /= 10)
    {
        Console.Write($", ");
        Console.Write($"0");
    }
}
else
{
    for (int k = i; k > 1 / 10; k /= 10)
    {
        if (num >= 1)
        {
            num2 = (double)num / k;
            num /= k;
            num3 = (num2 - num) * k;
            Console.Write($"{num}");
            Console.Write($", ");
        }
        else
        {
            Console.Write($"{num}");
        }
        num = (int)Math.Round(num3);

        if (((double)num / k == num / k) && (k >= 10))
        {
            Console.Write($"{num / k}");
            for (int j = k; k > 10; k /= 10)
            {
                Console.Write($", ");
                Console.Write($"0");
            }
            break;
        }        

    }
}
