using System;
namespace Calculator
{
    public class Calculator
    {
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }
        public double NumberInMemory { get; set; }
        
        public Calculator()
        {
            FirstNumber = 0;
            SecondNumber = 0;
            NumberInMemory = 0;
        }
        
        public double SumNumbers() => FirstNumber + SecondNumber;

        public double MultiplyNumbers() => FirstNumber * SecondNumber;

        public double SumInBetween()
        {
            double sum = 0;
            double smallestNumber = FirstNumber >= SecondNumber ? SecondNumber : FirstNumber;
            double largestNumber = FirstNumber <= SecondNumber ? SecondNumber : FirstNumber;
            
            for (double i = smallestNumber; i <= largestNumber; i++)
            {
                sum += smallestNumber;
                smallestNumber++;
            }
            return sum;
        }

        public void AddNumberToMemory(double num) 
        {
            NumberInMemory = num;
        }

        public override string ToString()
        {
            return $"First number: {FirstNumber}\n" +
                $"Second number: {SecondNumber}\n" +
                $"Number in memory: {NumberInMemory}";
        }
    }
}
