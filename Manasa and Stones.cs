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

    // Complete the stones function below.
    static List<int> stones(int n, int a, int b)
    {
        List<int> finalStones = new List<int>();
        for (int i = 0; i < n; i++)
        {
            int r = i * a + (n - i - 1) * b;
            if (finalStones.Contains(r) == false)
            {
                finalStones.Add(r);
            }
        }

        finalStones.Sort();
        return finalStones;
    }

    static void Main(string[] args)
    {

        int T = Convert.ToInt32(Console.ReadLine());

        for (int TItr = 0; TItr < T; TItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int a = Convert.ToInt32(Console.ReadLine());

            int b = Convert.ToInt32(Console.ReadLine());

            List<int> result = stones(n, a, b);

            for (int i = 0; i < result.Count; i++)
            {
                Console.Write(result[i] + " ");
            }
            Console.WriteLine("");
        }

    }
}
