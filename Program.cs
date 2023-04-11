using System;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = new int[10]; // создаем массив с 10 элементами
        Random rnd = new Random(); // создаем генератор случайных чисел

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = rnd.Next(100); // заполняем массив случайными числами от 0 до 99
            Console.Write($"{nums[i]} ");
        }

        int sum = 0;
        for (int i = 1; i < nums.Length; i += 2) // начинаем с 1, т.к. индексы массива начинаются с 0
        {
            sum += nums[i];
        }

        Console.WriteLine($"\nСумма элементов на нечетных позициях: {sum}");
    }
}
