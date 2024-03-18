using System;

class Program
{
    static void Main(string[] args)
    {
        // Создаем экземпляр класса Random для генерации случайного числа
        Random random = new Random();

        // Генерируем случайное число, которое пользователь должен угадать
        int targetNumber = random.Next(1, 10); // генерируем случайное число от 1 до 100

        Console.WriteLine("Угадайте число, которое я загадал (от 1 до 10):");

        // Просим пользователя угадать число до тех пор, пока он не угадает
        int guessedNumber;
        do
        {
            string input = Console.ReadLine();
            if (!int.TryParse(input, out guessedNumber))
            {
                Console.WriteLine("Введите целое число.");
                continue;
            }

            if (guessedNumber < targetNumber)
            {
                Console.WriteLine("Загаданное число больше.");
            }
            else if (guessedNumber > targetNumber)
            {
                Console.WriteLine("Загаданное число меньше.");
            }
            else
            {
                Console.WriteLine("Поздравляем! Вы угадали!");
                return; // завершаем программу, если число угадано
            }

            Console.WriteLine("Попробуйте еще раз:");
        } while (true);
    }
}


