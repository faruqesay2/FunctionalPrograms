//HARMONIC NUMBER :
//Any of a series of numbers formed from the sum of the
//reciprocals of consecutive natural numbers.


using System;
public class HarmonicNumber
{
    public static void Main()
    {
        int i, n;
        double s = 0.0;

        Console.Write("\n\n"); //use for breaking statement
        Console.Write("Calculate the harmonic series and their sum:\n"); //printing msg
        Console.Write("----------------------------------------------");
        Console.Write("\n\n"); //use for breaking statement

        Console.Write("Input the number of terms : "); //taking input from user 
        n = Convert.ToInt32(Console.ReadLine()); //converting string to intiger
        Console.Write("\n\n"); //breaking statement
        for (i = 1; i <= n; i++) //using for loop for  repeateating of code a known number of times.
        {
            Console.Write("1/{0} + ", i);
            s += 1 / (float)i; //representing the single floating number
        }
        Console.Write("\nSum of Series upto {0} terms : {1} \n", n, s);
    }
}
