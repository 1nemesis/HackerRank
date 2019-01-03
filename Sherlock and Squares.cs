using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        int T = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < T; i++)
        {
            String[] t = (Console.ReadLine() as String).Split(' ');
            int count = 0;
            int x1 = (int)Math.Ceiling(Math.Sqrt(Convert.ToInt32(t[0])));
            int x2 = (int)Math.Floor(Math.Sqrt(Convert.ToInt32(t[1])));

            if ((x2 - x1 + 1) > 0)
            {
                count = x2 - x1 + 1;
            }

            Console.WriteLine(count);
        }

    }
}

