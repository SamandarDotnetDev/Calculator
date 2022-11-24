using System;
namespace CALCULATOR.Classes
{
    class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public char Operation { get; set; }
        public  void Operator()
        {
            System.Console.Write("Type to 1st number :");
            FirstNumber = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter operator|+ , - , * , /|");
            Operation = Convert.ToChar(Console.ReadLine());
            System.Console.Write("Type to 2nd number :");
            SecondNumber = Convert.ToInt32(Console.ReadLine());
            string result = Operation switch
            {
            '+' => $"{FirstNumber} + {SecondNumber} = {FirstNumber + SecondNumber}",
            '-' => $"{FirstNumber} - {SecondNumber} = {FirstNumber - SecondNumber}",
            '*' => $"{FirstNumber} * {SecondNumber} = {FirstNumber * SecondNumber}",
            '/' => $"{FirstNumber} / {SecondNumber} = {FirstNumber / SecondNumber}",
            '%' => $"{FirstNumber} % {SecondNumber} = {FirstNumber % SecondNumber}",
            _ => "Operation Not Found!"
            };
            System.Console.WriteLine(result);
        }
        
    }
}
