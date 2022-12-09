using System;
using System.Threading;

namespace EvenOdd
{
    class program
    {
        static void Main(string[] args)  //entrance point by which a c# program can be run.
        {
            int num1; //creating varibale 
            Console.WriteLine("Enter the number to check odd or even"); //printing 
            num1 = int.Parse(Console.ReadLine());  //accepts a string and returns an int.
            if (num1 % 2 == 0) // for checking the devided number is equal to zero or not 
            {
                Console.WriteLine("Number is Even");
            }
            else //if its not even then its odd 
            {
                Console.WriteLine("Number is odd"); 
            }
            Console.ReadKey();
        }
    }
}
