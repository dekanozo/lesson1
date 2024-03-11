using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число в диапазоне от 10 до 99:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number >= 10 && number <= 99)
        {
            int maxDigit = GetMaxDigit(number);
            Console.WriteLine($"Наибольшая цифра числа {number} - {maxDigit}.");
        }
        else
        {
            Console.WriteLine("Ошибка: Введенное число не находится в диапазоне от 10 до 99.");
        }
    }

    static int GetMaxDigit(int number)
    {
        string numberString = number.ToString();
        int maxDigit = int.MinValue;

        foreach (char digit in numberString)
        {
            if (digit != '0' && digit > maxDigit)
            {
                maxDigit = Convert.ToInt32(digit.ToString());
            }
        }

        return maxDigit;
    }
}

