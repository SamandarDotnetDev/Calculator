using System;
using CALCULATOR.Classes;

    Security obj1 = new Security();
    obj1.security();



    System.Console.Write("Type to 1st number :");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Enter operator|+ , - , * , /|");
    string operation = Console.ReadLine();
    System.Console.Write("Type to 2nd number :");
    int secondNumber = Convert.ToInt32(Console.ReadLine());

    
    // System.Console.WriteLine($"Adding {firstNumber + secondNumber}");
    // System.Console.WriteLine($"Substracting {firstNumber - secondNumber}");
    // System.Console.WriteLine($"Substracting {firstNumber / secondNumber}");
    // System.Console.WriteLine($"Substracting {firstNumber * secondNumber}");
    // System.Console.WriteLine($"Qoldiq {firstNumber % secondNumber}");

    // System.Console.WriteLine(--firstNumber);
    // System.Console.WriteLine(firstNumber);

    // System.Console.WriteLine($"1st number is greated then 2nd number:{firstNumber > secondNumber}");
    // System.Console.WriteLine($"1st number is less then 2nd number:{firstNumber < secondNumber}");
    // System.Console.WriteLine($"1st number is equal then 2nd number:{firstNumber == secondNumber}");
    // System.Console.WriteLine($"1st number is greated then equal to 2nd number:{firstNumber >= secondNumber}");
    // System.Console.WriteLine($"1st number is less then equal to 2nd number:{firstNumber <= secondNumber}");
    // System.Console.WriteLine($"1st number is don't equal then 2nd number:{firstNumber != secondNumber}");

    //Switch

    // switch (operation)
    // {
    //   case "+":
    //     System.Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
    //     break;
    //   case "-":
    //     System.Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
    //     break;
    //   case "*":
    //     System.Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
    //     break;
    //   case "/":
    //     System.Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
    //     break;
    //   case "%":
    //     System.Console.WriteLine($"{firstNumber}ni  {secondNumber}ga bo'lgandagi qoldiq = {firstNumber % secondNumber}");
    //     break;
    //   default:
    //     System.Console.WriteLine("Operation Not Found!");
    //     break;
    // }

    // Switch Expressions
    string result = operation switch
    {
      "+" => $"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}",
      "-" => $"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}",
      "*" => $"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}",
      "/" => $"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}",
      "%" => $"{firstNumber} % {secondNumber} = {firstNumber % secondNumber}",
      _ => "Operation Not Found!"
    };

    System.Console.WriteLine(result);

    //While Loop
    // while (firstNumber >= secondNumber)
    // {
    //   if (secondNumber % 2 == 0)
    //   {
    //     System.Console.WriteLine(secondNumber);
    //   }
    //   secondNumber++;
    // }

    //For loop
    // for (int i = 1; i <= firstNumber; i++)
    // {
    //   if (i % 2 == 0)
    //   {
    //     System.Console.WriteLine(i);
    //   }
    // }

    for (int i = 0; i < 11; i++)
    {
      for (int n = 0; n < 11; n++)
      {
        System.Console.WriteLine($"{i} x {n} = {i * n}");
      }
    }

