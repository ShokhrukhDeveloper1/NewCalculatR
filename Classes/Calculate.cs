using System;

namespace NEWCALCULATR.Classes
{
  class Calculate
  {
    private int first;
    private int second;

    public Calculate(int FirstNumber, int SecondNumber)
    {
      first=FirstNumber;
      second=SecondNumber;
    }

    public void PositiveOrNegative()
    {
      string message =

        // (FirstNumber >= 0 && SecondNumber >= 0)
        //   ? "1st and/or 2nd numbers are positive!"
        //   : "1st and/or 2nd numbers are negative!";

        // (FirstNumber >= 0 || SecondNumber >= 0)
        //   ? "1st or 2nd numbers are positive!"
        //   : "1st or 2nd numbers are negative!";

        !(first >= 0)
          ? "1st number is not positive!"
          : "1st number is not negative!";

      Console.WriteLine(message);

      // if(first>=0)
      // {
      //   Console.WriteLine("1st number is positive!");
      // }
      // else
      // {
      //   Console.WriteLine("1st number is negative!");
      // }
    }
    public void Comparison()
    {
      if(first>second)
      {
        Console.WriteLine("1st number is greater than 2nd number!");
      }
      else if(first==second)
      {
        Console.WriteLine("1st number is equal to 2nd number!");
      }
      else
      {
        Console.WriteLine("1st number is less than 2nd number!");
      }
    }

    public string ArifmeticOperatios(string operation)
    {
      return operation switch
      {
        "+" => $"Adding: {first} + {second} = {first+second}",
        "-" => $"Subtracting: {first} - {second} = {first-second}",
        "/" => $"Divising: {first} / {second} = {first/second}",
        "*" => $"Multiplicating: {first} * {second} = {first*second}",
        _ => "Operation Not Found!"
      };
    }

    public void ArifmeticOperatios_2(string operation) // Switch ning 2-usuli
    {
      switch(operation)
      {
        case "+":
          Console.WriteLine($"Adding: {first} + {second} = {first+second}");
            break;
        case "-":
          Console.WriteLine($"Subtracting: {first} - {second} = {first-second}");
            break;
        case "/":
          Console.WriteLine($"Divising: {first} / {second} = {first/second}");
            break;
        case "*":
          Console.WriteLine($"Multiplicating: {first} * {second} = {first*second}");
            break;
        default:
          Console.WriteLine("Operation Not Found!");
            break;
      }
    }

    public void EvenNumbers()
    {
      Console.Write($"{first} raqamigacha bo'lgan juft sonlar: ");
      if(first>0)
      {
        int counter=0;
        while(counter<first)
        {
          if(counter%2==0)
          {
            Console.Write(counter+" ");
          }
          counter++;
        }
      }
    }

    public void MultiplicationTable()
    {
      for(int iterator=1;iterator<=10;iterator++)
      {
        for(int innerIterator=1;innerIterator<=10;innerIterator++)
        {
          Console.WriteLine($"{iterator} * {innerIterator} = {iterator*innerIterator}");
        }
        Console.WriteLine();
      }
    }

  }
}