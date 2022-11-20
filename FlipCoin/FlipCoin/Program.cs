using System;

namespace FlipCoin
{
    public class Program
    {
        static void Main(string[] args)
        {
            int h_cnt = 0,
                t_cnt = 0;




            Console.WriteLine("enter no. of times you want to flip the coin: ");
            int inp = Convert.ToInt32(Console.ReadLine());



            for (int i = 0; i < inp; i++)
            {
                Random random = new Random();
                int Random = random.Next(0, 2);
                if (Random < 0.5)
                    t_cnt++;
                else
                    h_cnt++;

            }

            double heads = h_cnt / (double)inp * 100;
            double tails = t_cnt / (double)inp * 100;
            Console.WriteLine("Percentage of heads: " + heads + "%");
            Console.WriteLine("Percentage of tails: " + tails + "%");


            Console.ReadLine();
        }
    }
}