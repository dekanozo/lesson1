using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите натуральное число:");
        BigInteger number = BigInteger.Parse(Console.ReadLine());

        if (number > 0)
        {
            string numberString = number.ToString();
            Console.WriteLine(string.Join(",", numberString.ToCharArray()));
        }
        else
        {
            Console.WriteLine("Ошибка: Введенное число не является натуральным.");
        }
    }
}


