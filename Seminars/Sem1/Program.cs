using System;

public class Answer {
    static void CompareNumbers(int firstNumber, int secondNumber)
    {
        if (firstNumber < secondNumber)
        {
            Console.WriteLine("второе число больше");
        } 
        else if (firstNumber > secondNumber)
        {
            Console.WriteLine("первое число больше");
        }
        else
        {
            Console.WriteLine("числа равны");
        }
    }

    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int firstNumber, secondNumber;

        if (args.Length >= 2) {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            firstNumber = 3;
            secondNumber = 3;
        }

        // Не удаляйте строки ниже
        CompareNumbers(firstNumber, secondNumber);
    }
}
