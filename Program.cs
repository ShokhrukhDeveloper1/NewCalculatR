using System;
using NEWCALCULATR.Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        Security security=new Security();
        security.InputPassword();

        Console.Write("First number is: ");
        int FirstNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter operation(+,-,*,/): ");
        string operation = Console.ReadLine();
        Console.Write("Second number is: ");
        int SecondNumber = Convert.ToInt32(Console.ReadLine());

        Calculate Count = new Calculate(FirstNumber, SecondNumber);

        Count.PositiveOrNegative();
        Count.Comparison();
        string result = Count.ArifmeticOperatios(operation);
        Console.WriteLine(result);
        //Count.ArifmeticOperatios_2(operation);  // Bu yerda switch ning 2-usuli void metodi orqali chaqirilgan
        Count.EvenNumbers();
        Console.WriteLine();
        Count.MultiplicationTable();
    }
}