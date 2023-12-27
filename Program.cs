using System;

System.Console.Write("First number is: ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
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

System.Console.WriteLine($"Adding: {FirstNumber} + {SecondNumber} = {FirstNumber+SecondNumber}");
System.Console.WriteLine($"Subtracting: {FirstNumber} - {SecondNumber} = {FirstNumber-SecondNumber}");
System.Console.WriteLine($"Divising: {FirstNumber} / {SecondNumber} = {FirstNumber/SecondNumber}");
System.Console.WriteLine($"Multiplicating: {FirstNumber} * {SecondNumber} = {FirstNumber*SecondNumber}\n");

// System.Console.WriteLine($"1st number greater than 2nd number: {FirstNumber>SecondNumber}");
// System.Console.WriteLine($"1st number greater than or equal to 2nd number: {FirstNumber>=SecondNumber}");
// System.Console.WriteLine($"1st number less than 2nd number: {FirstNumber<SecondNumber}");
// System.Console.WriteLine($"1st number less than or equal to 2nd number: {FirstNumber<=SecondNumber}");
// System.Console.WriteLine($"Numbers are not equal: {FirstNumber==SecondNumber}");
// System.Console.WriteLine($"Numbers are not equal: {FirstNumber!=SecondNumber}");