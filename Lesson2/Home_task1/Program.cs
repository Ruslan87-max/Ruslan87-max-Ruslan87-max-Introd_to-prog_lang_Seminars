// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 7 == 0 && num % 23 == 0) {
    Console.Write($"Число {num} кратно и 7, и 23");
}
else if (num % 7 == 0 && num % 23 != 0) {
    Console.Write($"Число {num} кратно 7, но не кратно 23");
}
else if (num % 7 != 0 && num % 23 == 0) {
    Console.Write($"Число {num} кратно 23, но не кратно 7");
}
else {
    Console.Write($"Число {num} не кратно ни 7, ни 23");
}
