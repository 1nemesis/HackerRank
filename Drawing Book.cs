using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    /*
     * Complete the pageCount function below.
     */
    static int pageCount(int n, int p)
    {
        if (p < n / 2)
        {
            return p / 2;
        }
        else if (p > n / 2 && n % 2 == 0)
        {
            return (n / 2) - (p / 2);
        }
        else if (p > n / 2 && p % 2 == 0)
        {
            return ((n - 1) / 2) - (p / 2);
        }
        else if (p == n / 2 && p % 2 != 0 && n % 2 != 0)
        {
            return ((n - 1) / 2) - ((p + 1) / 2);
        }

        else
        {
            return ((n - 1) / 2) - ((p - 1) / 2);
        }

    }

    static void Main(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine());

        int p = Convert.ToInt32(Console.ReadLine());

        int result = pageCount(n, p);

        Console.WriteLine(result);
    }
}
