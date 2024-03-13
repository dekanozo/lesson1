using System;

public class Answer {
    static void CompareNumbers(int firstNumber, int secondNumber)
    {
        if (firstNumber < secondNumber)
        {
            Console.WriteLine($"{secondNumber} больше, чем {firstNumber}");
        }
        else if (firstNumber > secondNumber)
        {
            Console.WriteLine($"{firstNumber} больше, чем {secondNumber}");
        }
        else
        {
            Console.WriteLine($"{firstNumber} равно {secondNumber}");
        }
    }
    
    // Пример использования метода CompareNumbers
    public static void Main(string[] args)
    {
        CompareNumbers(10, 5); // Пример вывода: 10 больше, чем 5
        CompareNumbers(5, 10); // Пример вывода: 10 больше, чем 5
        CompareNumbers(5, 5);  // Пример вывода: 5 равно 5
    }
}
