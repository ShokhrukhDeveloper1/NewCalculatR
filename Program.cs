﻿using System;

System.Console.Write("First number is: ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter operation(+,-,*,/): ");
string operation=Console.ReadLine();
System.Console.Write("Second number is: ");
int SecondNumber = Convert.ToInt32(Console.ReadLine());

string message =

  // (FirstNumber >= 0 && SecondNumber >= 0)
  //   ? "1st and/or 2nd numbers are positive!"
  //   : "1st and/or 2nd numbers are negative!";

  // (FirstNumber >= 0 || SecondNumber >= 0)
  //   ? "1st or 2nd numbers are positive!"
  //   : "1st or 2nd numbers are negative!";

  !(FirstNumber >= 0)
    ? "1st number is not positive!"
    : "1st number is not negative!";

System.Console.WriteLine(message);

// if(FirstNumber>=0)
// {
//   System.Console.WriteLine("1st number is positive!");
// }
// else
// {
//   System.Console.WriteLine("1st number is negative!");
// }

if(FirstNumber>SecondNumber)
{
  System.Console.WriteLine("1st number is greater than 2nd number!");
}
else if(FirstNumber==SecondNumber)
{
  System.Console.WriteLine("1st number is equal to 2nd number!");
}
else
{
  System.Console.WriteLine("1st number is less than 2nd number!");
}

string result = operation switch
{
  "+" => $"Adding: {FirstNumber} + {SecondNumber} = {FirstNumber+SecondNumber}",
  "-" => $"Subtracting: {FirstNumber} - {SecondNumber} = {FirstNumber-SecondNumber}",
  "/" => $"Divising: {FirstNumber} / {SecondNumber} = {FirstNumber/SecondNumber}",
  "*" => $"Multiplicating: {FirstNumber} * {SecondNumber} = {FirstNumber*SecondNumber}",
  _ => "Operation Not Found!"
};
System.Console.WriteLine(result);

// switch(operation)
// {
//   case "+":
//     System.Console.WriteLine($"Adding: {FirstNumber} + {SecondNumber} = {FirstNumber+SecondNumber}");
//       break;
//   case "-":
//     System.Console.WriteLine($"Subtracting: {FirstNumber} - {SecondNumber} = {FirstNumber-SecondNumber}");
//       break;
//   case "/":
//     System.Console.WriteLine($"Divising: {FirstNumber} / {SecondNumber} = {FirstNumber/SecondNumber}");
//       break;
//   case "*":
//     System.Console.WriteLine($"Multiplicating: {FirstNumber} * {SecondNumber} = {FirstNumber*SecondNumber}");
//       break;
//   default:
//     System.Console.WriteLine("Operation Not Found!");
//       break;
// }

// System.Console.WriteLine($"1st number greater than 2nd number: {FirstNumber>SecondNumber}");
// System.Console.WriteLine($"1st number greater than or equal to 2nd number: {FirstNumber>=SecondNumber}");
// System.Console.WriteLine($"1st number less than 2nd number: {FirstNumber<SecondNumber}");
// System.Console.WriteLine($"1st number less than or equal to 2nd number: {FirstNumber<=SecondNumber}");
// System.Console.WriteLine($"Numbers are not equal: {FirstNumber==SecondNumber}");
// System.Console.WriteLine($"Numbers are not equal: {FirstNumber!=SecondNumber}");

if(FirstNumber>0)
{
  int counter=0;
  while(counter<FirstNumber)
  {
    if(counter%2==0)
    {
      System.Console.Write(counter+" ");
    }
    counter++;
  }
}
System.Console.WriteLine();

for(int iterator=1;iterator<=10;iterator++)
{
  for(int innerIterator=1;innerIterator<=10;innerIterator++)
  {
    System.Console.WriteLine($"{iterator} * {innerIterator} = {iterator*innerIterator}");
  }
  System.Console.WriteLine();
}