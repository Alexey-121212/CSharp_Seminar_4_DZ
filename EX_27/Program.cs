// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11 82 -> 10 9012 -> 12

int num;

Console.Clear();

Console.WriteLine("Введите целое число:");
num = Math.Abs(Convert.ToInt32(Console.ReadLine()));

Console.WriteLine($"Сумма цифр = {sumOfDigits(num)}");

// Methods

int sumOfDigits(int number)
{
    int summa = number % 10;

    while ((number / 10) >= 1)
    {
        number /= 10;
        summa += number % 10;
    }
    return summa;
}