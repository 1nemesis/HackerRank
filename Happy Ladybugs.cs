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

    // Complete the happyLadybugs function below.
    static string happyLadybugs(string b)
    {
        int a = 0;
        int f = 0;
        if (b.Length == 1 && b == "_")
            return "YES";
        else if (b.Length == 1)
            return "NO";
        for (int i = 0; i < b.Length; i++)
        {
            if (i == 0)
            {
                if (b[i] == b[i + 1])
                    continue;
                else
                    f++;
                continue;
            }
            else if (i == b.Length - 1)
            {
                if (b[b.Length - 1] == b[b.Length - 2])
                    continue;
                else
                    f++;
                continue;
            }
            else
            {
                if (b[i] == b[i - 1] || b[i] == b[i + 1])
                    continue;
                f++;
            }
        }
        if (f == 0)
            return "YES";
        List<int> count = new List<int>();
        {
            for (int i = 0; i < b.Length; i++)
            {
                int c = 0;
                if (b[i] == '_')
                {
                    a++;
                    continue;
                }
                for (int j = 0; j < b.Length; j++)
                {
                    if (b[i] == b[j])
                        c++;
                }
                count.Add(c);
                if (c == 1)
                    return "NO";
            }
            if (a == 0 && count.Contains(b.Length))
                return "YES";
            else if (a == 0)
                return "NO";
            return "YES";
        }


    }

    static void Main(string[] args)
    {
        int g = Convert.ToInt32(Console.ReadLine());

        for (int gItr = 0; gItr < g; gItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string b = Console.ReadLine();

            string result = happyLadybugs(b);

            Console.WriteLine(result);
        }
    }
}