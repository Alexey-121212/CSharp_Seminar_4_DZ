// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵) 2, 4 -> 16

int num;
int degree;

Console.Clear();

Console.WriteLine("Введите целое число:");
num = Convert.ToInt32(Console.ReadLine());

do
{
    Console.WriteLine("Введите степень - натуральное число:");
    degree = Convert.ToInt32(Console.ReadLine());
} while (degree < 1);

Console.WriteLine($"{num} в степени {degree} = {DoDegree(num, degree)}");


// Methods

int DoDegree(int number, int deg)
{
    int result = number;

    for (int i = 2; i <= deg; i++)
    {
        result *= number;
    }
    return result;
}
