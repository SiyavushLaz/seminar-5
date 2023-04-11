using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество элементов в массиве: ");
        int size = int.Parse(Console.ReadLine()); // ввод размера массива

        int[] nums = new int[size]; // создание массива заданного размера
        Console.WriteLine($"Введите {size} элементов массива:");

        // заполнение массива элементами, введенными пользователем
        for (int i = 0; i < size; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        // подсчет количества четных чисел в массиве
        int evenCount = 0;
        foreach (int num in nums)
        {
            if (num % 2 == 0)
            {
                evenCount++;
            }
        }

        Console.WriteLine($"Количество четных чисел в массиве: {evenCount}.");
    }
}
