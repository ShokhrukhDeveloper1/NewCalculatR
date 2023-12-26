using System;

System.Console.Write("First number is: ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Second number is: ");
int SecondNumber = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Adding: {FirstNumber} + {SecondNumber} = {FirstNumber+SecondNumber}");
System.Console.WriteLine($"Subtracting: {FirstNumber} - {SecondNumber} = {FirstNumber-SecondNumber}");
System.Console.WriteLine($"Divising: {FirstNumber} / {SecondNumber} = {FirstNumber/SecondNumber}");
System.Console.WriteLine($"Multiplicating: {FirstNumber} * {SecondNumber} = {FirstNumber*SecondNumber}\n");

System.Console.WriteLine($"1st number greater than 2nd number: {FirstNumber>SecondNumber}");
System.Console.WriteLine($"1st number greater than or equal to 2nd number: {FirstNumber>=SecondNumber}");
System.Console.WriteLine($"1st number less than 2nd number: {FirstNumber<SecondNumber}");
System.Console.WriteLine($"1st number less than or equal to 2nd number: {FirstNumber<=SecondNumber}");
System.Console.WriteLine($"Numbers are not equal: {FirstNumber==SecondNumber}");
System.Console.WriteLine($"Numbers are not equal: {FirstNumber!=SecondNumber}");