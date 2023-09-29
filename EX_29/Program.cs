// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 6, 1, 33 -> [6, 1, 33]

Console.Clear();

int[] arr = new int[8];

arr = EnterArray(8);

Console.WriteLine();

PrintArray(arr);

// Methods

int[] EnterArray(int length)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"Введите {i} элемент массива (целое число)");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0 | i == arr.Length - 1)
        {
            if (i == 0)
            {
                Console.Write($"[{arr[i]}");
            }
            else
            {
                Console.Write($", {arr[i]}]");
            }
        }
        else
        {
            Console.Write($", {arr[i]}");
        }

    }
}
