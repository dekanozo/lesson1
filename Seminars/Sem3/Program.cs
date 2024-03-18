using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число для проверки: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            if (IsDivisibleBy7And23(number))
            {
                Console.WriteLine($"{number} кратно одновременно 7 и 23.");
            }
            else
            {
                Console.WriteLine($"{number} не кратно одновременно 7 и 23.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка: Введите целое число.");
        }
    }

    static bool IsDivisibleBy7And23(int number)
    {
        return number % 7 == 0 && number % 23 == 0;
    }
}
