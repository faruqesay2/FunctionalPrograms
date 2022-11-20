using System;

class Program
{
    static void Main(string[] args)
    {
        //input number is 7
        int num = 4;
        int tempNum, flag;

        tempNum = num;
        flag = 0;
        /*check power of two*/
        while (tempNum != 1)
        {
            if (tempNum % 2 != 0)
            {
                flag = 1;
                break;
            }
            tempNum = tempNum / 2;
        }

        if (flag == 0)
            Console.WriteLine("{0} is a number that is the power of 2.", num);
        else
            Console.WriteLine("{0} is not the power of 2.", num);
    }
}