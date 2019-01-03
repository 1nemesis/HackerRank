using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    /*
     * Complete the getMoneySpent function below.
     */
    static long getMoneySpent(long[] keyboards, long[] drives, long b)
    {
        long a = 0;
        long d = 0;
        for (long i = 0; i < keyboards.Length; i++)
        {

            for (long j = 0; j < drives.Length; j++)
            {
                long total = keyboards[i] + drives[j];
                long difference = b - total;
                if (difference == 0)
                {
                    return total;
                }
                if (difference >= 0 && d == 0)
                {
                    d = difference;
                    a = total;
                }
                else if (difference >= 0 && difference < d)
                {
                    d = difference;
                    a = total;
                }
            }
        }
        if (a != 0)
        {
            return a;
        }
        else
        {
            return -1;
        }

    }

    static void Main(string[] args)
    {


        string[] bnm = Console.ReadLine().Split(' ');

        long b = Convert.ToInt64(bnm[0]);

        long n = Convert.ToInt64(bnm[1]);

        long m = Convert.ToInt64(bnm[2]);

        long[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt64(keyboardsTemp))
        ;

        long[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt64(drivesTemp))
        ;
        /*
         * The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
         */

        long moneySpent = getMoneySpent(keyboards, drives, b);
        Console.WriteLine(moneySpent);


    }
}
