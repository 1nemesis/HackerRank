using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the saveThePrisoner function below.
    static long saveThePrisoner(long n, long m, long s)
    {


        long b = m % n - 1;

        if (b < 0)
        {
            if (s != 1)
            {
                return s - 1;
            }
            else
            {
                return n;
            }
        }
        if (b + s > n)
        {

            return (b - (n - s));
        }

        return s + b;


    }

    static void Main(string[] args)
    {


        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] nms = Console.ReadLine().Split(' ');

            long n = Convert.ToInt64(nms[0]);

            long m = Convert.ToInt64(nms[1]);

            long s = Convert.ToInt64(nms[2]);

            long result = saveThePrisoner(n, m, s);

            Console.WriteLine(result);
        }


    }
}
