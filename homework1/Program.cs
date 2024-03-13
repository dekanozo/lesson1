using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsMultipleOf7And23(number))
        {
            Console.WriteLine($"Число {number} кратно одновременно 7 и 23.");
        }
        else
        {
            Console.WriteLine($"Число {number} не кратно одновременно 7 и 23.");
        }
    }

    static bool IsMultipleOf7And23(int number)
    {
        return (number % 7 == 0) && (number % 23 == 0);
    }
}

