using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение X:");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение Y:");
        double y = Convert.ToDouble(Console.ReadLine());

        if (x != 0 && y != 0)
        {
            int coordQuarter = getCoordQuarter(x, y);
            Console.WriteLine($"Точка находится в координатной четверти под номером {coordQuarter}.");
        }
        else
        {
            Console.WriteLine("Ошибка: X или Y равно нулю.");
        }
    }

    static int getCoordQuarter(double x, double y)
    {
        if (x > 0 && y > 0)
        {
            return 1;
        }
        else if (x < 0 && y > 0)
        {
            return 2;
        }
        else if (x < 0 && y < 0)
        {
            return 3;
        }
        else if (x > 0 && y < 0)
        {
            return 4;
        }
        else
        {
            throw new ArgumentException("Ошибка: X или Y равно нулю.");
        }
    }
}

