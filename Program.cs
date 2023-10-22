using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


namespace hw13 {
    /*
    //1
    delegate void DisplayMessage(string message);

    class Program
    {
        static void Main()
        {
            DisplayMessage displayMessage = ShowMessage;

            displayMessage("Це текстове повідомлення.");
            displayMessage("Це ще одне повідомлення.");

            Console.ReadLine();
        }

        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
    */

    /*
     //2
    delegate double MathOperation(double a, double b);

    class Program
    {
        static void Main()
        {
            MathOperation add = (a, b) => a + b;
            MathOperation subtract = (a, b) => a - b;
            MathOperation multiply = (a, b) => a * b;

            double result1 = Calculate(5, 3, add);
            double result2 = Calculate(8, 2, subtract);
            double result3 = Calculate(4, 6, multiply);

            Console.WriteLine($"Додавання: {result1}");
            Console.WriteLine($"Віднімання: {result2}");
            Console.WriteLine($"Множення: {result3}");

            Console.ReadLine();
        }

        static double Calculate(double a, double b, MathOperation operation)
        {
            return operation(a, b);
        }
    }
    */

    //3
    delegate bool NumberCheck(int number);

    class Program
    {
        static void Main()
        {
            NumberCheck isEven = IsEven;
            NumberCheck isOdd = IsOdd;
            NumberCheck isPrime = IsPrime;
            NumberCheck isFibonacci = IsFibonacci;

            int num1 = 6;
            int num2 = 7;

            Console.WriteLine($"{num1} парне: {isEven(num1)}");
            Console.WriteLine($"{num2} парне: {isEven(num2)}");

            Console.WriteLine($"{num1} просте: {isPrime(num1)}");
            Console.WriteLine($"{num2} просте: {isPrime(num2)}");

            Console.WriteLine($"{num1} число Фібоначчі: {isFibonacci(num1)}");
            Console.WriteLine($"{num2} число Фібоначчі: {isFibonacci(num2}");

            Console.ReadLine();
        }

        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }

        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        static bool IsFibonacci(int number)
        {
            double sqrt5 = Math.Sqrt(5);
            double phi = (1 + sqrt5) / 2;
            int n = number;

            double fibCheck = (Math.Pow(phi, n) - Math.Pow(1 - phi, n)) / sqrt5;

            return fibCheck == (int)fibCheck;
        }
    }
}