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

    // Complete the gameOfThrones function below.
    static string gameOfThrones(string s)
    {
        List<int> count = new List<int>();
        List<char> c = new List<char>();
        for (int i = 0; i < s.Length; i++)
        {
            int a = 1;
            if (c.Contains(s[i]) == false)
            {
                c.Add(s[i]);
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                        a++;
                }
                count.Add(a);
            }

        }
        int o = 0;
        for (int i = 0; i < count.Count; i++)
        {
            if (count[i] % 2 == 1)
                o++;
        }
        if (o > 1)
            return "NO";
        return "YES";
    }

    static void Main(string[] args)
    {
        string s = Console.ReadLine();

        string result = gameOfThrones(s);

        Console.WriteLine(result);
    }
}
