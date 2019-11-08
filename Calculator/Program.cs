using System;

namespace Calculator
{
    class MainClass
    {
        public static Calculator calculator = new Calculator();

        public static void Main(string[] args)
        {
            bool looping = true;
            while (looping)
            {
                Console.WriteLine("1. Add two numbers\n" +
                              "2. Multiply two numbers\n" +
                              "3. Sum the numbers between two numbers\n" +
                              "4. Add number to memory\n" +
                              "5. Clear memory\n" +
                              "6. Print calculator contents\n" +
                              "7. Quit\n");

                switch (Console.ReadLine())
                {
                    case "1":
                        Add();
                        break;
                    case "2":
                        Multiply();
                        break;
                    case "3":
                        SumInBetween();
                        break;
                    case "4":
                        NumberInMemory();
                        break;
                    case "5":
                        ClearMemory();
                        break;
                    case "6":
                        PrintCalculatorContents();
                        break;
                    case "7":
                        Console.WriteLine("Goodbye");
                        looping = false;
                        break;
                }
            }
        }

        private static void Add()
        {
            SetNumbersToCalculator("Print two numbers to add");
            Console.WriteLine($"Sum of numbers is {calculator.SumNumbers()}");
        }  

        private static void Multiply()
        {
            SetNumbersToCalculator("Print two numbers to multiply");
            Console.WriteLine($"Product of numbers is {calculator.MultiplyNumbers()}\n");            
        }

        private static void SumInBetween()
        {
            SetNumbersToCalculator("Print two numbers to sum in between");
            Console.WriteLine($"Sum of numbers in between is {calculator.SumInBetween()}\n");            
        }

        private static void NumberInMemory()
        {
            Console.WriteLine("Add a number to memory");
            double numInMemory;
            if (double.TryParse(Console.ReadLine(), out numInMemory))
            {
                calculator.AddNumberToMemory(numInMemory);
                Console.WriteLine("Number successfully added to memory");
            }
            else
            {
                Console.WriteLine("You must only print a number");
            }            
        }

        private static void ClearMemory()
        {
            calculator = new Calculator();
            Console.WriteLine("Number in memory cleared");
        }
       
        private static void PrintCalculatorContents() => Console.WriteLine(calculator);
        
        private static void SetNumbersToCalculator(string message)
        {
            Console.WriteLine(message);       
            double firstNumber, secondNumber;
            if (double.TryParse(Console.ReadLine(), out firstNumber) && double.TryParse(Console.ReadLine(), out secondNumber))
            {
                calculator.FirstNumber = firstNumber;
                calculator.SecondNumber = secondNumber;
            }
            else
            {
                Console.WriteLine("You must only print numbers");
            }
        }
    }  
}
