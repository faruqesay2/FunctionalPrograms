//The quotient is the number of times a division is completed fully.
//the remainder is the amount left that doesn't entirely go into the divisor

using System;

class Program
{
    static void Main(string[] args)
    {

        int dividend = 13200, divisor = 5;

        int quotient = dividend / divisor;
        int remainder = dividend % divisor;

        Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
        Console.WriteLine("Quotient = " + quotient);
        Console.WriteLine("Remainder = " + remainder);
        Console.ReadLine();
    }
}
